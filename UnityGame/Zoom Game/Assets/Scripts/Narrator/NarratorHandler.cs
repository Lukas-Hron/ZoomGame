using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class NarratorHandler : MonoBehaviour
{
    public string rhymeToUse = "ly";
    public static NarratorHandler Instance;
    public List<NarratorVoiceLine> NarrVoiceLineList;
    private List<NarratorVoiceLine> KeyWordVoiceLines;

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

    public void AddToPlaylist(NarratorVoiceLine voiceLine)
    {
        NarratorPlaylist.Instance.AddVoiceLineToPlaylist(voiceLine);
    }
}
