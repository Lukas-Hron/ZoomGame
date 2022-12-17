using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NarratorPlaylist : MonoBehaviour
{
    public static NarratorPlaylist Instance;


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
        
        if (NarratorVoiceLinePlaylist[0] != null)
        {
            AudioHandler.Instance.PlaySoundEffect(NarratorVoiceLinePlaylist[0].voiceLine);
            Invoke(methodName: "PlayNextVoiceline", NarratorVoiceLinePlaylist[0].voiceLine.length + 0.5f);
        }
        else
        isPlaying = false;
            

        NarratorVoiceLinePlaylist.RemoveAt(0);
    }
}
