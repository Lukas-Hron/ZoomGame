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
        firstSubtitles = "Lily is a curious girl, her heart full of wonder, She loves to explore and learn, and let her mind wander.";
        secondSubtitles = "Her bright eyes sparkle with joy and delight, laughs and giggles from morning to night. But she always made sure to tread carefully";
        timeToSplit = 7.5f;
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
        firstSubtitles = "Lily is a curious girl, always asking why, Her mind is full of wonder and she is never shy.";
        secondSubtitles = "Learning new things and to explore. Her want for adventure grew ever more. Lily knew loads about adventuring.";
        timeToSplit = 7.7f;
        keyWord = "opening";
        AddVoiceLine();



        /////////////////////////////////////////////////////Lamp

        // ly >> ed
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_lamp_ly_ed");
        recievingRhyme = "ly";
        endingRhyme = "ed";
        firstSubtitles = "On the ceiling a lamp shined so brightly. Even her parents couldn't reach that high.";
        secondSubtitles = "Although she's never seen them try. She'd rather just imagine instead.";
        timeToSplit = 5.5f;
        keyWord = "lamp";
        AddVoiceLine();

        // ing >> ly
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_lamp_ing_ly");
        recievingRhyme = "ing";
        endingRhyme = "ly";
        firstSubtitles = "She was often very caring. Once when the light in the hallway went out,";
        secondSubtitles = "Lily came to help without a doubt. And after that the light shined brightly.";
        timeToSplit = 4.7f;
        keyWord = "lamp";
        AddVoiceLine();

        // ed >> ing
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_lamp_ed_ing");
        recievingRhyme = "ed";
        endingRhyme = "ing";
        firstSubtitles = "Just like the light up ahead. Lily's bright mind shines with why's and how's.";
        secondSubtitles = "Even when she's looking around her house. To her, thinking is almost as good as doing.";
        timeToSplit = 5.7f;
        keyWord = "lamp";
        AddVoiceLine();



        /////////////////////////////////////////////////////Flower

        //ly >> ed
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_flower_ly_ed");
        recievingRhyme = "ly";
        endingRhyme = "ed";
        firstSubtitles = "Her favorite flower is also called Lily. She's a dreamer, her head in the clouds.";
        secondSubtitles = "She loves to imagine and let her mind wander proud. Even when she's trying to sleep in bed.";
        timeToSplit = 5.4f;
        keyWord = "flower";
        AddVoiceLine();

        //ed >> ing
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_flower_ed_ing");
        recievingRhyme = "ed";
        endingRhyme = "ing";
        firstSubtitles = "She often imagines herself in a flower bed. A bed of lilies just like her mom told her about.";
        secondSubtitles = "Which was her favorite place when she was a scout. Her mom would go there just to sing.";
        timeToSplit = 6.3f;
        keyWord = "flower";
        AddVoiceLine();

        //ing >> ly
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_flower_ing_ly");
        recievingRhyme = "ing";
        endingRhyme = "ly";
        firstSubtitles = "The lily flowers are blooming. So delicate and fragile, yet so strong,";
        secondSubtitles = "A symbol of love, it cannot go wrong. Although she often gets called silly.";
        timeToSplit = 5.3f;
        keyWord = "flower";
        AddVoiceLine();



        /////////////////////////////////////////////////////sign

        //ly >> ed
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_sign_ly_ed");
        recievingRhyme = "ly";
        endingRhyme = "ed";
        firstSubtitles = "Once they made a sign together, letting anyone know Lily lives here whenever.";
        secondSubtitles = "She has her own room with her own bed.";
        timeToSplit = 5.3f;
        keyWord = "sign";
        AddVoiceLine();

        //ed >> ing
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_sign_ed_ing");
        recievingRhyme = "ed";
        endingRhyme = "ing";
        firstSubtitles = "Lily door was signed. Signed by herself with her own paint.";
        secondSubtitles = "Even with her parents restraint. Everyone knows lily loves painting.";
        timeToSplit = 4.1f;
        keyWord = "sign";
        AddVoiceLine();

        //ing >> ly
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_sign_ing_ly");
        recievingRhyme = "ing";
        endingRhyme = "ly";
        firstSubtitles = "Lily loves spending time decorating. Her door was covered in stickers once, it was the prettiest door around.";
        secondSubtitles = "But her parents made her take it all down. They said she put them on too messily.";
        timeToSplit = 6.4f;
        keyWord = "sign";
        AddVoiceLine();



        ///////////////////////////////////////////////////// drawing

        //ly >> ed
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_drawing_ly_ed");
        recievingRhyme = "ly";
        endingRhyme = "ed";
        firstSubtitles = "Her father says her art is painterly. She can't help but feel proud";
        secondSubtitles = "But she always gets embarrassed when he says it out loud. Though he never regrets what he's said.";
        timeToSplit = 4.2f;
        keyWord = "drawing";
        AddVoiceLine();

        //ed >> ing
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_drawing_ed_ing");
        recievingRhyme = "ed";
        endingRhyme = "ing";
        firstSubtitles = "She tapes her drawings above her bed. She loves the way they brightened up her room";
        secondSubtitles = "and how they seemed to sway. Almost as much as she loves drawing.";
        timeToSplit = 4.7f;
        keyWord = "drawing";
        AddVoiceLine();

        //ing >> ly
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_drawing_ing_ly");
        recievingRhyme = "ing";
        endingRhyme = "ly";
        firstSubtitles = "More than anything, Lily loves drawing. She loves the way the pencil feels in her hand";
        secondSubtitles = "and how easy it is to understand. Her parents always said she drew beautifully.";
        timeToSplit = 5.7f;
        keyWord = "drawing";
        AddVoiceLine();



        ///////////////////////////////////////////////////// bedroom

        //ly >> ed
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_bedroom_ly_ed");
        recievingRhyme = "ly";
        endingRhyme = "ed";
        firstSubtitles = "In her house there's a room just for Lily. It is a place where she can be herself and not have to hide.";
        secondSubtitles = "Her room will always be a place where she can reside. That's just what her mother said.";
        timeToSplit = 6.5f;
        keyWord = "bedroom";
        AddVoiceLine();

        //ed >> ing
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_bedroom_ed_ing");
        recievingRhyme = "ed";
        endingRhyme = "ing";
        firstSubtitles = "Lily loves everything about her room, from the books on her shelves";
        secondSubtitles = "to her warm comfy bed. Even her friends are jealous of her bedding.";
        timeToSplit = 3.5f;
        keyWord = "bedroom";
        AddVoiceLine();

        //ing >> ly
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_bedroom_ing_ly");
        recievingRhyme = "ing";
        endingRhyme = "ly";
        firstSubtitles = "Lily has her own room where she likes playing. It is where she feels most at home,";
        secondSubtitles = "with her cozy bed made out of foam. Even if it does get chilly.";
        timeToSplit = 5.2f;
        keyWord = "bedroom";
        AddVoiceLine();



        ///////////////////////////////////////////////////// pillow

        //ly >> ed
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_pillow_ly_ed");
        recievingRhyme = "ly";
        endingRhyme = "ed";
        firstSubtitles = "Lily makes her bed carefully. Making sure every pillow is in the right place.";
        secondSubtitles = "Leaving not a single empty space. She's proud of how she makes her bed.";
        timeToSplit = 4.7f;
        keyWord = "pillow";
        AddVoiceLine();

        //ed >> ing
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_pillow_ed_ing");
        recievingRhyme = "ed";
        endingRhyme = "ing";
        firstSubtitles = "She sometimes hides things in her bed. Maybe a sock, shirt or even a remote.";
        secondSubtitles = "Once she even hid her dad's coat. But he got mad so she stopped the hiding.";
        timeToSplit = 5.5f;
        keyWord = "pillow";
        AddVoiceLine();

        //ing >> ly
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_pillow_ing_ly");
        recievingRhyme = "ing";
        endingRhyme = "ly";
        firstSubtitles = "Lily doesn't like sleeping. She would rather stay awake all night,";
        secondSubtitles = "after all she does have her nightlight. Even though she tackles the dark fearlessly.";
        timeToSplit = 4.4f;
        keyWord = "pillow";
        AddVoiceLine();



        ///////////////////////////////////////////////////// tv

        //ly >> ed
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_tv_ly_ed");
        recievingRhyme = "ly";
        endingRhyme = "ed";
        firstSubtitles = "Lily's tv glows brightly.";
        secondSubtitles = "Brightly with the glow of her favorite show. The show that's called Golden Red.";
        timeToSplit = 2.2f;
        keyWord = "tv";
        AddVoiceLine();

        //ed >> ing
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_tv_ed_ing");
        recievingRhyme = "ed";
        endingRhyme = "ing";
        firstSubtitles = "Lily's favorite tv show is called Golden Red. She watches it every friday noon.";
        secondSubtitles = "It tells the tale of a girl and the moon. She loves it even if some scenes are shocking.";
        timeToSplit = 5.6f;
        keyWord = "tv";
        AddVoiceLine();

        //ing >> ly
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_tv_ing_ly");
        recievingRhyme = "ing";
        endingRhyme = "ly";
        firstSubtitles = "Lily is always watching. Her TV, her movies, when she isn't busy drawing.";
        secondSubtitles = "Her favorite movies are always kind of silly.";
        timeToSplit = 4.8f;
        keyWord = "tv";
        AddVoiceLine();



        ///////////////////////////////////////////////////// tunnel

        //ly >> ed
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_tunnel_ly");
        recievingRhyme = "ly";
        endingRhyme = "ed";
        firstSubtitles = "What's up it's me! The troll under the- in the.. the cave... and stuff";
        secondSubtitles = "Yoo man.. fuck you! Bitch. What the fuck you doin' here huh?";
        timeToSplit = 4.6f;
        keyWord = "gate";
        AddVoiceLine();

        //ed >> ing
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_tunnel_ed");
        recievingRhyme = "ed";
        endingRhyme = "ing";
        firstSubtitles = "What's up it's me! The troll under the- in the.. the cave... and stuff";
        secondSubtitles = "Yoo man.. fuck you! Bitch. What the fuck you doin' here huh?";
        timeToSplit = 4.6f;
        keyWord = "gate";
        AddVoiceLine();

        //ing >> ly
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_tunnel_ing");
        recievingRhyme = "ing";
        endingRhyme = "ly";
        firstSubtitles = "What's up it's me! The troll under the- in the.. the cave... and stuff";
        secondSubtitles = "Yoo man.. fuck you! Bitch. What the fuck you doin' here huh?";
        timeToSplit = 4.6f;
        keyWord = "gate";
        AddVoiceLine();



        ///////////////////////////////////////////////////// end

        //ly >> ed
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_end_ly");
        recievingRhyme = "ly";
        endingRhyme = "ed";
        firstSubtitles = "And then Lily died because she was a bitch. Even though she smelled like a fish.";
        secondSubtitles = "I'm not gonna write three different lines so you'll have to... figure this one out cause it doesn't rhyme.. Yeah!..";
        timeToSplit = 5f;
        keyWord = "end";
        AddVoiceLine();

        //ed >> ing
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_end_ed");
        recievingRhyme = "ed";
        endingRhyme = "ing";
        firstSubtitles = "And then Lily died because she was a bitch. Even though she smelled like a fish.";
        secondSubtitles = "I'm not gonna write three different lines so you'll have to... figure this one out cause it doesn't rhyme.. Yeah!..";
        timeToSplit = 5f;
        keyWord = "end";
        AddVoiceLine();

        //ing >> ly
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_end_ing");
        recievingRhyme = "ing";
        endingRhyme = "ly";
        firstSubtitles = "And then Lily died because she was a bitch. Even though she smelled like a fish.";
        secondSubtitles = "I'm not gonna write three different lines so you'll have to... figure this one out cause it doesn't rhyme.. Yeah!..";
        timeToSplit = 5f;
        keyWord = "end";
        AddVoiceLine();




    }
    private void AddVoiceLine()
    {
        NarratorHandler.Instance.NarrVoiceLineList.Add(new NarratorVoiceLine(voiceLine,keyWord,recievingRhyme,endingRhyme,timeToSplit,firstSubtitles,secondSubtitles));
    }
}
