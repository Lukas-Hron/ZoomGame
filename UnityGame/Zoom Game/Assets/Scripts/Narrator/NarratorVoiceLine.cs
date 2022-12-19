using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NarratorVoiceLine 
{
    public AudioClip voiceLine;
    public string recievingRhyme, endingRhyme, subtitles,keyWord;

    public NarratorVoiceLine
    (
        AudioClip audioClip,
        string keyWord,
        string recievingRhyme,
        string endingRhyme,
        string subtitles
    )
    {
        voiceLine = audioClip;
        this.keyWord = keyWord;
        this.recievingRhyme = recievingRhyme;
        this.endingRhyme = endingRhyme;
        this.subtitles = subtitles;

    }


}
