using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NarratorVoiceLine 
{
    public AudioClip voiceLine;
    public string recievingRhyme, endingRhyme, firstSubtitles, secondSubtitles, keyWord;
    public float timeToSplit;

    public NarratorVoiceLine
    (
        AudioClip audioClip,
        string keyWord,
        string recievingRhyme,
        string endingRhyme,
        float timeToSplit,
        string firstSubtitles,
        string secondSubtitles
    )
    {
        voiceLine = audioClip;
        this.keyWord = keyWord;
        this.recievingRhyme = recievingRhyme;
        this.endingRhyme = endingRhyme;
        this.firstSubtitles = firstSubtitles;
        this.secondSubtitles = secondSubtitles;
        this.timeToSplit = timeToSplit;

    }


}
