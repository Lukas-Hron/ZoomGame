using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NarratorPlaylist : MonoBehaviour
{
    public static NarratorPlaylist Instance;
    public Subtitles subtitle;
    public List<NarratorVoiceLine> NarratorVoiceLinePlaylist;
    bool isPlaying;

    private void Start()
    {
        NarratorVoiceLinePlaylist = new List<NarratorVoiceLine>();
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
            AudioHandler.Instance.PlaySoundEffect(NarratorVoiceLinePlaylist[0].voiceLine);
            subtitle.playSubtitle(NarratorVoiceLinePlaylist[0].firstSubtitles, NarratorVoiceLinePlaylist[0].secondSubtitles,NarratorVoiceLinePlaylist[0].voiceLine.length, NarratorVoiceLinePlaylist[0].timeToSplit);
            Invoke(methodName: "PlayNextVoiceline", NarratorVoiceLinePlaylist[0].voiceLine.length + 0.5f);
            NarratorVoiceLinePlaylist.RemoveAt(0);
        }
        else
        isPlaying = false;
            

        
    }
}
