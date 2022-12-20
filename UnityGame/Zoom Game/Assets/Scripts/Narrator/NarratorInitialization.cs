using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NarratorInitialization : MonoBehaviour
{
    private AudioClip voiceLine;
    public string recievingRhyme, endingRhyme, firstSubtitles, secondSubtitles, keyWord;
    public float timeToSplit;



    private void Start()
    {
        NarratorHandler.Instance.InitializeLists();
        /////////////////////////////////////////////////////Openings

        //ly
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_opening_ly");
        recievingRhyme = "ly";
        endingRhyme = "ly";
        firstSubtitles = "Lily is a curious girl, with a heart full of wonder, She loves to explore and learn, and let her mind wander. Her bright eyes sparkle with joy and delight,";
        secondSubtitles = "And she loves to laugh and giggle, morning and night. But she always made sure to tread carefully";
        timeToSplit = 10f;
        keyWord = "opening";
        AddVoiceLine();

        //ed
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_opening_ed");
        recievingRhyme = "ed";
        endingRhyme = "ed";
        firstSubtitles = "Lily is a kind and caring friend, She always helps others and is never at an end. Her gentle nature shines bright and true,";
        secondSubtitles = "Just like her dress, which is always blue. But only because she doesn't like red.";
        timeToSplit = 8.5f;
        keyWord = "opening";
        AddVoiceLine();

        //ing
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_opening_ing");
        recievingRhyme = "ing";
        endingRhyme = "ing";
        firstSubtitles = "Lily is a curious soul, always asking why, Her mind is full of wonder and she is never shy. She loves to learn new things and explore,";
        secondSubtitles = "Her want for adventure grew ever more. Lily knew loads about adventuring.";
        timeToSplit = 10.7f;
        keyWord = "opening";
        AddVoiceLine();

        /////////////////////////////////////////////////////Lamp

        // ly >> ed
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_light_ly_ed");
        recievingRhyme = "ly";
        endingRhyme = "ed";
        firstSubtitles = "On the ceiling a lamp shined so brightly. Even her parents couldn't reach that high. Although she's never seen them try. She'd rather just imagine instead. ";
        keyWord = "lamp";
        AddVoiceLine();

        // ing >> ly
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_light_ing_ly");
        recievingRhyme = "ing";
        endingRhyme = "ly";
        firstSubtitles = "She was often very caring. Once when the light in the hallway went out Lily came to help without a doubt. And after that the light shined brightly.";
        keyWord = "lamp";
        AddVoiceLine();

        // ed >> ing
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_light_ed_ing");
        recievingRhyme = "ed";
        endingRhyme = "ing";
        firstSubtitles = "Just like the light up ahead. Lily's bright mind shines with why's and how's. Even when she's looking around her house. To her, thinking is almost as good as doing.";
        keyWord = "lamp";
        AddVoiceLine();

        /////////////////////////////////////////////////////Flower

        //ly >> ed
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_flower_ly_ed");
        recievingRhyme = "ly";
        endingRhyme = "ed";
        firstSubtitles = "Her favorite flower is also called Lily. She is a dreamer, her head in the clouds She loves to imagine and let her mind wander proud. Even when she's trying to sleep in bed.";
        keyWord = "flower";
        AddVoiceLine();

        //ed >> ing
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_flower_ed_ing");
        recievingRhyme = "ed";
        endingRhyme = "ing";
        firstSubtitles = "She often imagines herself in a flower bed. A bed of lilies just like her mom told her about. Which was her favorite place when she was a scout. Her mom would go there just to sing.";
        keyWord = "flower";
        AddVoiceLine();

        //ing >> ly
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_flower_ing_ly");
        recievingRhyme = "ing";
        endingRhyme = "ly";
        firstSubtitles = "The lily flowers are blooming. So delicate and fragile, yet so strong, A symbol of love, it cannot go wrong. Although she often gets called silly.";
        keyWord = "flower";
        AddVoiceLine();

        /////////////////////////////////////////////////////sign

        //ly >> ed
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_sign_ly_ed");
        recievingRhyme = "ly";
        endingRhyme = "ed";
        firstSubtitles = "Lily was happy with her family. Once they made a sign together, letting anyone know Lily lives here whenever.  She has her own room with her own bed.";
        keyWord = "sign";
        AddVoiceLine();

        //ed >> ing
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_sign_ed_ing");
        recievingRhyme = "ed";
        endingRhyme = "ing";
        firstSubtitles = "Lily door was signed. Signed by herself with her own paint.Even with her parents restraint. Everyone knows lily loves painting.";
        keyWord = "sign";
        AddVoiceLine();

        //ing >> ly
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_sign_ing_ly");
        recievingRhyme = "ing";
        endingRhyme = "ly";
        firstSubtitles = "Lily loves spending time decorating. Her door was covered in stickers once, it was the prettiest door around. But her parents made her take it all down. They said she put them on too messily. ";
        keyWord = "sign";
        AddVoiceLine();
    }
    private void AddVoiceLine()
    {
        NarratorHandler.Instance.NarrVoiceLineList.Add(new NarratorVoiceLine(voiceLine,keyWord,recievingRhyme,endingRhyme,timeToSplit,firstSubtitles,secondSubtitles));
    }
}
