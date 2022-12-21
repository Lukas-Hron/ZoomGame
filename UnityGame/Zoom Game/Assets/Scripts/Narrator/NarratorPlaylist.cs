using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NarratorPlaylist : MonoBehaviour
{
    public static NarratorPlaylist Instance;
    public Subtitles subtitle;
    NarratorVoiceLine currentlyPlaying;
    public List<NarratorVoiceLine> NarratorVoiceLinePlaylist;
    public List<NarratorVoiceLine> HasPlayed;
    NarratorHandler narrHandler;
    bool isPlaying;
    float fullPlaylistTime;

    private void Start()
    {
        NarratorVoiceLinePlaylist = new List<NarratorVoiceLine>();
        HasPlayed = new List<NarratorVoiceLine>();
        narrHandler = GetComponent<NarratorHandler>();
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

        if (NarratorVoiceLinePlaylist.Count > 0)
        {
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

    public void PlayEnding()
    {
        NarratorVoiceLinePlaylist.Clear();

        narrHandler.rhymeToUse = currentlyPlaying.endingRhyme;
        narrHandler.PlayFromKeyWord("gate");

        foreach (NarratorVoiceLine voiceline in HasPlayed)
        {
            narrHandler.PlayFromName(voiceline.voiceLine.name + "_end");
        }
        narrHandler.PlayFromKeyWord("end");

        fullPlaylistTime = 0;
        foreach (NarratorVoiceLine voiceline in NarratorVoiceLinePlaylist)
        {
            fullPlaylistTime += voiceline.voiceLine.length;
        }
        FindObjectOfType<CutsceneManager>().duration = fullPlaylistTime;
    }
}
