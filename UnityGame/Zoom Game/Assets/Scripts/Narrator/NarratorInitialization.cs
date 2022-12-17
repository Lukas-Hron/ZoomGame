using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NarratorInitialization : MonoBehaviour
{
    private AudioClip voiceLine;
    private string recievingRhyme, endingRhyme, subtitles, keyWord;



    private void Awake()
    {
        NarratorHandler.Instance.InitializeLists();
        /////////////////////////////////////////////////////Openings

        //ly
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_opening_ly");
        recievingRhyme = "ly";
        endingRhyme = "ly";
        subtitles = "Lily is a curious girl, with a heart full of wonder She loves to explore and learn, and let her mind wander. Her bright eyes sparkle with joy and delight, And she loves to laugh and giggle, morning and night. But she always made sure to tread carefully";
        keyWord = "opening";
        AddVoiceLine();

        //ed
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_opening_ed");
        recievingRhyme = "ed";
        endingRhyme = "ed";
        subtitles = "Lily is a kind and caring friend, She always helps others and is never at an end. Her gentle nature shines bright and true, Just like her dress, which is always blue. But only because she doesnÅft like red.";
        keyWord = "opening";
        AddVoiceLine();

        //ing
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_opening_ing");
        recievingRhyme = "ing";
        endingRhyme = "ing";
        subtitles = "Lily is a curious soul, always asking why, Her mind is full of wonder and she is never shy. She loves to learn new things and explore, Her want for adventure grew ever more. Lily knew loads about adventuring. ";
        keyWord = "opening";
        AddVoiceLine();

        /////////////////////////////////////////////////////Lamp

        // ly >> ed
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_light_ly_ed");
        recievingRhyme = "ly";
        endingRhyme = "ed";
        subtitles = "On the ceiling a lamp shined so brightly. Even her parents couldnÅft reach that high. Although sheÅfs never seen them try. SheÅfd rather just imagine instead. ";
        keyWord = "lamp";
        AddVoiceLine();

        // ing >> ly
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_light_ing_ly");
        recievingRhyme = "ing";
        endingRhyme = "ly";
        subtitles = "She was often very caring. Once when the light in the hallway went out Lily came to help without a doubt. And after that the light shined brightly.";
        keyWord = "lamp";
        AddVoiceLine();

        // ed >> ing
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_light_ed_ing");
        recievingRhyme = "ed";
        endingRhyme = "ing";
        subtitles = "Just like the light up ahead. LilyÅfs bright mind shines with whyÅfs and howÅfs. Even when sheÅfs looking around her house. To her, thinking is almost as good as doing.";
        keyWord = "lamp";
        AddVoiceLine();

        /////////////////////////////////////////////////////Flower

        //ly >> ed
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_flower_ly_ed");
        recievingRhyme = "ly";
        endingRhyme = "ed";
        subtitles = "Her favorite flower is also called Lily. She is a dreamer, her head in the clouds She loves to imagine and let her mind wander proud. Even when sheÅfs trying to sleep in bed.";
        keyWord = "flower";
        AddVoiceLine();

        //ed >> ing
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_flower_ed_ing");
        recievingRhyme = "ed";
        endingRhyme = "ing";
        subtitles = "She often imagines herself in a flower bed. A bed of lilies just like her mom told her about. Which was her favorite place when she was a scout. Her mom would go there just to sing.";
        keyWord = "flower";
        AddVoiceLine();

        //ed >> ing
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_flower_ing_ly");
        recievingRhyme = "ing";
        endingRhyme = "ly";
        subtitles = "The lily flowers are blooming. So delicate and fragile, yet so strong, A symbol of love, it cannot go wrong. Although she often gets called silly.";
        keyWord = "flower";
        AddVoiceLine();
    }
    private void AddVoiceLine()
    {
        NarratorHandler.Instance.NarrVoiceLineList.Add(new NarratorVoiceLine(voiceLine, keyWord, recievingRhyme, endingRhyme, subtitles));
    }
}
