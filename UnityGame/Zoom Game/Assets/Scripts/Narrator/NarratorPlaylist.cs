using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NarratorPlaylist : MonoBehaviour
{
    public bool buffer = false;
    public static NarratorPlaylist Instance;
    public Subtitles subtitle;
    NarratorVoiceLine currentlyPlaying;
    public List<NarratorVoiceLine> NarratorVoiceLinePlaylist;
    public List<NarratorVoiceLine> HasPlayed;
    NarratorHandler narrHandler;
    bool isPlaying;
    float fullPlaylistTime;
    Player player;

    private void Start()
    {
        NarratorVoiceLinePlaylist = new List<NarratorVoiceLine>();
        HasPlayed = new List<NarratorVoiceLine>();
        narrHandler = GetComponent<NarratorHandler>();
        player = FindObjectOfType<Player>();
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

    public void AddVoiceLineToPlaylist(NarratorVoiceLine voiceLine)
    {
        NarratorVoiceLinePlaylist.Add(voiceLine);

        if (!isPlaying)
        {
            isPlaying = true;
            PlayNextVoiceline();
        }
    }

    public void PlayNextVoiceline()
    {
        if (!buffer)
        {

            if (NarratorVoiceLinePlaylist.Count > 0)
            {
                if (NarratorVoiceLinePlaylist[0].keyWord == "gate")
                {
                    player.inCutscene = true;
                }


                AudioHandler.Instance.PlayNarration(NarratorVoiceLinePlaylist[0].voiceLine);
                subtitle.playSubtitle(NarratorVoiceLinePlaylist[0].firstSubtitles, NarratorVoiceLinePlaylist[0].secondSubtitles, NarratorVoiceLinePlaylist[0].voiceLine.length, NarratorVoiceLinePlaylist[0].timeToSplit);
                Invoke(methodName: "PlayNextVoiceline", NarratorVoiceLinePlaylist[0].voiceLine.length + 0.5f);
                currentlyPlaying = NarratorVoiceLinePlaylist[0];
                HasPlayed.Add(NarratorVoiceLinePlaylist[0]); //Add it to the lines that have been played
                NarratorVoiceLinePlaylist.RemoveAt(0);
                Debug.Log(currentlyPlaying.voiceLine.name);

            }
            else
                isPlaying = false;

        }
        else
        {
            isPlaying = false;
        }



    }

    public void PlayEnding()
        {
        buffer = true;
        NarratorVoiceLinePlaylist.Clear();

        narrHandler.rhymeToUse = currentlyPlaying.endingRhyme;
        narrHandler.PlayFromKeyWord("gate");

        //foreach (NarratorVoiceLine voiceline in HasPlayed)
        //{
        //    narrHandler.PlayFromName(voiceline.voiceLine.name + "_end");
        //}

        //TEMP
        foreach (NarratorVoiceLine voiceline in HasPlayed)
        {
            narrHandler.PlayFromName(voiceline.voiceLine.name);
        }
        fullPlaylistTime = 0;
        buffer = false;
        narrHandler.PlayFromKeyWord("end");
        foreach (NarratorVoiceLine voiceline in NarratorVoiceLinePlaylist)
        {
            fullPlaylistTime += voiceline.voiceLine.length +0.5f;
        }
        FindObjectOfType<CutsceneManager>().duration = fullPlaylistTime;



    }
}
