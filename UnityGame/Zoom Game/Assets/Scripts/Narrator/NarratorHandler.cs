using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class NarratorHandler : MonoBehaviour
{
    public string rhymeToUse;
    public static NarratorHandler Instance;
    public List<NarratorVoiceLine> NarrVoiceLineList;
    private List<NarratorVoiceLine> KeyWordVoiceLines;

    private void Start()
    {
        //choose random start line
        int randomInt = Random.Range(1, 4);
        if (randomInt == 1)
            rhymeToUse = "ly";
        else if (randomInt == 2)
            rhymeToUse = "ing";
        else
            rhymeToUse = "ed";
    }
    public void InitializeLists()
    {
     NarrVoiceLineList = new List<NarratorVoiceLine>();
     KeyWordVoiceLines = new List<NarratorVoiceLine>();
    }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public void PlayFromKeyWord(string keyWord)
    {
        KeyWordVoiceLines.Clear();
        foreach (NarratorVoiceLine voiceLine in NarrVoiceLineList)
        {
            if (voiceLine.keyWord == keyWord)
            {
                KeyWordVoiceLines.Add(voiceLine);
            }
        }

        foreach (NarratorVoiceLine voiceLine in KeyWordVoiceLines)
        {
            if (voiceLine.recievingRhyme == rhymeToUse)
            {
                rhymeToUse = voiceLine.endingRhyme;
                AddToPlaylist(voiceLine);
                return;
            }
        }
    }

    public void PlayFromName(string name)
    {
        foreach (NarratorVoiceLine voiceLine in NarrVoiceLineList)
        {
            try
            {
                if (voiceLine.voiceLine.name == name)
                {
                    AddToPlaylist(voiceLine);
                }
            }
            catch
            {
                Debug.LogError("Couldn't find " + name + ".");
            }
        }
    }


    public void AddToPlaylist(NarratorVoiceLine voiceLine)
    {
        NarratorPlaylist.Instance.AddVoiceLineToPlaylist(voiceLine);
    }
}
