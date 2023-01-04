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
        secondSubtitles = "Her bright eyes sparkle with joy and delight and she loves to laugh and giggle, morning to night. Always with a smile so lovely";
        timeToSplit = 7.5f;
        keyWord = "opening";
        AddVoiceLine();

        //ed
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_opening_ed");
        recievingRhyme = "ed";
        endingRhyme = "ed";
        firstSubtitles = "Lily is a kind and caring friend, She always helps others and is never at an end. Her gentle nature shines bright and true,";
        secondSubtitles = "Just like her dress, which is always blue. She’s the nicest girl around just like her mother always said.";
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
        firstSubtitles = "Her favorite flower is also called Lily.";
        secondSubtitles = "This is the one Lily planted";
        timeToSplit = 5.4f;
        keyWord = "flower";
        AddVoiceLine();

        //ed >> ing
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_flower_ed_ing");
        recievingRhyme = "ed";
        endingRhyme = "ing";
        firstSubtitles = "The lily flowers have grown into a nice spread.";
        secondSubtitles = "It’s amazing how the old petals keep regrowing.";
        timeToSplit = 6.3f;
        keyWord = "flower";
        AddVoiceLine();

        //ing >> ly
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_flower_ing_ly");
        recievingRhyme = "ing";
        endingRhyme = "ly";
        firstSubtitles = "The lilies are blooming.";
        secondSubtitles = "They have grown rapidly.";
        timeToSplit = 2.3f;
        keyWord = "flower";
        AddVoiceLine();



        /////////////////////////////////////////////////////sign

        //ly >> ed
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_sign_ly_ed");
        recievingRhyme = "ly";
        endingRhyme = "ed";
        firstSubtitles = "Lily was happy with her family. Once they made a sign together,";
        secondSubtitles = "letting anyone know Lily lives here whenever. She has her own room with her own bed.";
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
        firstSubtitles = "She has a shelf where she will keep all the books she’s read.";
        secondSubtitles = "It’s empty for now since she just got into reading.";
        timeToSplit = 3.5f;
        keyWord = "bedroom";
        AddVoiceLine();

        //ing >> ly
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_bedroom_ing_ly");
        recievingRhyme = "ing";
        endingRhyme = "ly";
        firstSubtitles = "Lily has her own room where she likes playing. It is where she feels most at home, with her cozy bed that’s softer than foam.";
        secondSubtitles = "In the mornings, the sun shines through the window, waking her softly.";
        timeToSplit = 6.2f;
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
        firstSubtitles = "She sometimes hides things in her bed. Maybe a sock, shirt or even the remote.";
        secondSubtitles = "Once she even hid her father's coat. He went around looking for the whole evening.";
        timeToSplit = 5.5f;
        keyWord = "pillow";
        AddVoiceLine();

        //ing >> ly
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_pillow_ing_ly");
        recievingRhyme = "ing";
        endingRhyme = "ly";
        firstSubtitles = "Lily doesn't like sleeping. She would rather stay awake all night,";
        secondSubtitles = "after all she does have her light. Even though she tackles the dark fearlessly.";
        timeToSplit = 4.4f;
        keyWord = "pillow";
        AddVoiceLine();



        ///////////////////////////////////////////////////// tv

        //ly >> ed
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_tv_ly_ed");
        recievingRhyme = "ly";
        endingRhyme = "ed";
        firstSubtitles = "Lily's tv glows brightly.";
        secondSubtitles = "Brightly with the glow of her favorite show. The show that’s called “A Tailor's Thread”.";
        timeToSplit = 2.2f;
        keyWord = "tv";
        AddVoiceLine();

        //ed >> ing
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_tv_ed_ing");
        recievingRhyme = "ed";
        endingRhyme = "ing";
        firstSubtitles = "Lily’s favorite show is called “A Tailor’s Thread” She watches it every Friday afternoon.";
        secondSubtitles = "It’s about a girl with powers from the moon. She loves it even if some scenes are shocking.";
        timeToSplit = 5.6f;
        keyWord = "tv";
        AddVoiceLine();

        //ing >> ly
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_tv_ing_ly");
        recievingRhyme = "ing";
        endingRhyme = "ly";
        firstSubtitles = "Lily is always watching. Her TV, her movies, when she isn’t busy drawing.";
        secondSubtitles = "Her favorite movies are always kind of silly.";
        timeToSplit = 4.8f;
        keyWord = "tv";
        AddVoiceLine();



        ///////////////////////////////////////////////////// painting transition

        //ly >> ed
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_field_ly_ed");
        recievingRhyme = "ly";
        endingRhyme = "ed";
        firstSubtitles = "A field of flowers she remembers so fondly.";
        secondSubtitles = "It must have changed alot since she last visited.";
        timeToSplit = 3.2f;
        keyWord = "field";
        AddVoiceLine();

        //ed >> ing
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_field_ed_ing");
        recievingRhyme = "ed";
        endingRhyme = "ing";
        firstSubtitles = "Lily is proud of the picture she painted.";
        secondSubtitles = "It’s a picture of a field she visited last spring.";
        timeToSplit = 3.6f;
        keyWord = "field";
        AddVoiceLine();

        //ing >> ly
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_field_ing_ly");
        recievingRhyme = "ing";
        endingRhyme = "ly";
        firstSubtitles = "An open field is the best place for running.";
        secondSubtitles = "With plains of grass growing endlessly.";
        timeToSplit = 3.8f;
        keyWord = "field";
        AddVoiceLine();


        ///////////////////////////////////////////////////// mouse puzzle

        //ly >> ed
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_mouse_ly_ed");
        recievingRhyme = "ly";
        endingRhyme = "ed";
        firstSubtitles = "Lily always treats animals kindly.";
        secondSubtitles = "Especially the mice living under the shed.";
        timeToSplit = 2.2f;
        keyWord = "mouse";
        AddVoiceLine();

        //ed >> ing
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_mouse_ed_ing");
        recievingRhyme = "ed";
        endingRhyme = "ing";
        firstSubtitles = "Lily takes care of the mice living under the shed.";
        secondSubtitles = "Taking care of animals is her second favorite thing.";
        timeToSplit = 2.6f;
        keyWord = "mouse";
        AddVoiceLine();

        //ing >> ly
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_mouse_ing_ly");
        recievingRhyme = "ing";
        endingRhyme = "ly";
        firstSubtitles = "Lily loves any cute little thing.";
        secondSubtitles = "Being a mouse is no exception to being treated kindly.";
        timeToSplit = 2.8f;
        keyWord = "mouse";
        AddVoiceLine();



        ///////////////////////////////////////////////////// rocket puzzle


        //ly >> ed
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_rocket_ly_ed");
        recievingRhyme = "ly";
        endingRhyme = "ed";
        firstSubtitles = "When Lily grows up she wants to be an astronaut exploring the galaxy.";
        secondSubtitles = "She pretends to walk on planets she has discovered.";
        timeToSplit = 2.2f;
        keyWord = "rocket";
        AddVoiceLine();

        //ed >> ing
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_rocket_ed_ing");
        recievingRhyme = "ed";
        endingRhyme = "ing";
        firstSubtitles = "She flew across the night sky with the rockets fired.";
        secondSubtitles = "Down on the distant surface she was looking.";
        timeToSplit = 2.6f;
        keyWord = "rocket";
        AddVoiceLine();

        //ing >> ly
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_rocket_ing_ly");
        recievingRhyme = "ing";
        endingRhyme = "ly";
        firstSubtitles = "Playing astronauts never gets tiring.";
        secondSubtitles = "Exploring new universes all across the galaxy.";
        timeToSplit = 2.8f;
        keyWord = "rocket";
        AddVoiceLine();



        ///////////////////////////////////////////////////// wheelbarrow puzzle

        //ly >> ed
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_wheel_ly_ed");
        recievingRhyme = "ly";
        endingRhyme = "ed";
        firstSubtitles = "She often spent time in the garden with her mother only.";
        secondSubtitles = "Taking care of her very own Lily she planted.";
        timeToSplit = 2.2f;
        keyWord = "wheel";
        AddVoiceLine();

        //ed >> ing
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_wheel_ed_ing");
        recievingRhyme = "ed";
        endingRhyme = "ing";
        firstSubtitles = "Their garden has a big pretty flower bed.";
        secondSubtitles = "Lily often helps with the gardening.";
        timeToSplit = 2.6f;
        keyWord = "wheel";
        AddVoiceLine();

        //ing >> ly
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_wheel_ing_ly");
        recievingRhyme = "ing";
        endingRhyme = "ly";
        firstSubtitles = "She often helps her mother with the gardening.";
        secondSubtitles = "A nice way to spend some time with her mother only.";
        timeToSplit = 2.8f;
        keyWord = "wheel";
        AddVoiceLine();


        ///////////////////////////////////////////////////// gate

        //ly >> ed
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_tunnel_ly");
        recievingRhyme = "ly";
        endingRhyme = "ed";
        firstSubtitles = "Our time here has gone by and we have to leave shortly. Although it has been nice telling you about Lily and her dreams,";
        secondSubtitles = "Every happy story like this has to come to an end it seems.";
        timeToSplit = 4.6f;
        keyWord = "gate";
        AddVoiceLine();

        //ed >> ing
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_tunnel_ed");
        recievingRhyme = "ed";
        endingRhyme = "ing";
        firstSubtitles = "Look back on the path you’ve traveled. Although it has been nice telling you about Lily and her dreams,";
        secondSubtitles = "Every happy story like this has to come to an end it seems.";
        timeToSplit = 4.6f;
        keyWord = "gate";
        AddVoiceLine();

        //ing >> ly
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_tunnel_ing");
        recievingRhyme = "ing";
        endingRhyme = "ly";
        firstSubtitles = "Sometimes we don’t have a say in where we’re going. Although it has been nice telling you about Lily and her dreams,";
        secondSubtitles = "Every happy story like this has to come to an end it seems.";
        timeToSplit = 4.6f;
        keyWord = "gate";
        AddVoiceLine();



        ///////////////////////////////////////////////////// end

        //ly >> ed
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_end_ly");
        recievingRhyme = "ly";
        endingRhyme = "ed";
        firstSubtitles = "I’m glad you came all this way to hear about Lily. She would’ve loved to be your friend.";
        secondSubtitles = "Having you there, keeping her company until the end.";
        timeToSplit = 5f;
        keyWord = "end";
        AddVoiceLine();

        //ed >> ing
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_end_ed");
        recievingRhyme = "ed";
        endingRhyme = "ing";
        firstSubtitles = "We both wish this wasn’t the way the story ended. She would’ve loved to be your friend.";
        secondSubtitles = "Having you there, keeping her company until the end.";
        timeToSplit = 5f;
        keyWord = "end";
        AddVoiceLine();

        //ing >> ly
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_end_ing");
        recievingRhyme = "ing";
        endingRhyme = "ly";
        firstSubtitles = "If Lily could ask for just one last thing. She would’ve loved to be your friend.";
        secondSubtitles = "Having you there, keeping her company until the end.";
        timeToSplit = 5f;
        keyWord = "end";
        AddVoiceLine();





        /////////////////////////////////////////////// PAST TENSE






        ///////////////////////////////////////////////////// Openings 

        //ly
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_opening_ly_end");
        recievingRhyme = "ly";
        endingRhyme = "ly";
        firstSubtitles = "Lily was a curious girl, with a heart full of wonder, She loved to explore and learn and let her mind wander.";
        secondSubtitles = "Her bright eyes sparkled with joy and delight as she used to laugh and giggle, morning and night. Always with a smile so lovely.";
        timeToSplit = 7.5f;
        keyWord = "keyword";
        AddVoiceLine();

        //ed
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_opening_ed_end");
        recievingRhyme = "ed";
        endingRhyme = "ed";
        firstSubtitles = "Lily was a kind and caring friend, She always helped others and was never at an end. Her gentle nature shined bright and true,";
        secondSubtitles = "Just like her dress which was always blue. She was the nicest girl around just like her mother always said.";
        timeToSplit = 8.5f;
        keyWord = "keyword";
        AddVoiceLine();

        //ing
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_opening_ing_end");
        recievingRhyme = "ing";
        endingRhyme = "ing";
        firstSubtitles = "Lily was a curious soul, always asking why. Her mind was full of wonder and she was never shy.";
        secondSubtitles = "She loved to learn new things and explore, Her want for adventure would have grown ever more. Lily knew loads about adventuring.";
        timeToSplit = 7.7f;
        keyWord = "keyword";
        AddVoiceLine();



        /////////////////////////////////////////////////////Lamp

        // ly >> ed
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_lamp_ly_ed_end");
        recievingRhyme = "ly";
        endingRhyme = "ed";
        firstSubtitles = "On the ceiling a lamp used to shine brightly. Even her parents couldn’t reach that high.";
        secondSubtitles = "Although she never saw them try. She’d rather just imagine instead.";
        timeToSplit = 5.5f;
        keyWord = "keyword";
        AddVoiceLine();

        // ing >> ly
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_lamp_ing_ly_end");
        recievingRhyme = "ing";
        endingRhyme = "ly";
        firstSubtitles = "She was always very caring. One time when the light went out,";
        secondSubtitles = "Lily came to help without a doubt. After that the light shined ever brightly.";
        timeToSplit = 4.7f;
        keyWord = "keyword";
        AddVoiceLine();

        // ed >> ing
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_lamp_ed_ing_end");
        recievingRhyme = "ed";
        endingRhyme = "ing";
        firstSubtitles = "Just like the light up ahead. Lily’s bright mind used to shine with why’s and how’s.";
        secondSubtitles = "Even when she's looking around her house. To her, thinking is almost as good as doing.";
        timeToSplit = 5.7f;
        keyWord = "keyword";
        AddVoiceLine();



        /////////////////////////////////////////////////////Flower

        //ly >> ed
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_flower_ly_ed_end");
        recievingRhyme = "ly";
        endingRhyme = "ed";
        firstSubtitles = "Her favorite flower was the Lily.";
        secondSubtitles = "That’s why she had it planted.";
        timeToSplit = 5.4f;
        keyWord = "keyword";
        AddVoiceLine();

        //ed >> ing
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_flower_ed_ing_end");
        recievingRhyme = "ed";
        endingRhyme = "ing";
        firstSubtitles = "The lily flowers had grown into a nice spread.";
        secondSubtitles = "It’s amazing how to old petals kept regrowing.";
        timeToSplit = 6.3f;
        keyWord = "keyword";
        AddVoiceLine();

        //ing >> ly
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_flower_ing_ly_end");
        recievingRhyme = "ing";
        endingRhyme = "ly";
        firstSubtitles = "The lilies were blooming.";
        secondSubtitles = "They had grown so rapidly.";
        timeToSplit = 2.3f;
        keyWord = "keyword";
        AddVoiceLine();



        /////////////////////////////////////////////////////sign

        //ly >> ed
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_sign_ly_ed_end");
        recievingRhyme = "ly";
        endingRhyme = "ed";
        firstSubtitles = "Lily was happy with her family. Once they made a sign together,";
        secondSubtitles = "letting anyone know Lily lived there whenever. She had her own room with her own bed.";
        timeToSplit = 5.3f;
        keyWord = "keyword";
        AddVoiceLine();

        //ed >> ing
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_sign_ed_ing_end");
        recievingRhyme = "ed";
        endingRhyme = "ing";
        firstSubtitles = "Lily’s door used to be signed. Signed by herself with her own paint.";
        secondSubtitles = "Even with her parent’s restraint. Everyone knew Lily loved painting.";
        timeToSplit = 4.1f;
        keyWord = "keyword";
        AddVoiceLine();

        //ing >> ly
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_sign_ing_ly_end");
        recievingRhyme = "ing";
        endingRhyme = "ly";
        firstSubtitles = "Lily loved spending time decorating. Her door was covered in stickers once, it was the prettiest door around.";
        secondSubtitles = "But her parents made her take it all down. They said she put them on too messily.";
        timeToSplit = 6.4f;
        keyWord = "keyword";
        AddVoiceLine();



        ///////////////////////////////////////////////////// drawing

        //ly >> ed
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_drawing_ly_ed_end");
        recievingRhyme = "ly";
        endingRhyme = "ed";
        firstSubtitles = "Her father said her art was painterly. She didn’t understand but couldn’t help but to feel proud.";
        secondSubtitles = "But she always got embarrassed when he said it out loud. Though he never regretted what he said.";
        timeToSplit = 4.2f;
        keyWord = "keyword";
        AddVoiceLine();

        //ed >> ing
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_drawing_ed_ing_end");
        recievingRhyme = "ed";
        endingRhyme = "ing";
        firstSubtitles = "She used to tape her drawings above her bed. She loved the way they would brighten up the room,";
        secondSubtitles = "and how they seemed to sway. Almost as much as she loved drawing.";
        timeToSplit = 4.7f;
        keyWord = "keyword";
        AddVoiceLine();

        //ing >> ly
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_drawing_ing_ly_end");
        recievingRhyme = "ing";
        endingRhyme = "ly";
        firstSubtitles = "More than anything, Lily loved drawing. She loved the way the pencil felt in her hand";
        secondSubtitles = "and how easy it was to understand. Her parents always said she drew beautifully.";
        timeToSplit = 5.7f;
        keyWord = "keyword";
        AddVoiceLine();



        ///////////////////////////////////////////////////// bedroom

        //ly >> ed
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_bedroom_ly_ed_end");
        recievingRhyme = "ly";
        endingRhyme = "ed";
        firstSubtitles = "In her house there was a room just for Lily. It was a place where she could be herself and not have to hide.";
        secondSubtitles = "Her room would always be a place where she could reside. At Least that’s what her mother always said.";
        timeToSplit = 6.5f;
        keyWord = "keyword";
        AddVoiceLine();

        //ed >> ing
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_bedroom_ed_ing_end");
        recievingRhyme = "ed";
        endingRhyme = "ing";
        firstSubtitles = "She had a shelf where she would keep all the books she had read.";
        secondSubtitles = "It was empty since she had just gotten into reading.";
        timeToSplit = 3.5f;
        keyWord = "keyword";
        AddVoiceLine();

        //ing >> ly
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_bedroom_ing_ly_end");
        recievingRhyme = "ing";
        endingRhyme = "ly";
        firstSubtitles = "Lily had her own room where she liked playing. It’s where she felt most at home, with her cozy bed that was softer than foam.";
        secondSubtitles = "In the mornings, the sun used to shine through the window, waking her softly.";
        timeToSplit = 6.2f;
        keyWord = "keyword";
        AddVoiceLine();



        ///////////////////////////////////////////////////// pillow

        //ly >> ed
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_pillow_ly_ed_end");
        recievingRhyme = "ly";
        endingRhyme = "ed";
        firstSubtitles = "Lily used to make her bed carefully. Making sure every pillow was in the right place.";
        secondSubtitles = "Leaving not a single empty space. She was proud of how she made her bed.";
        timeToSplit = 4.7f;
        keyWord = "keyword";
        AddVoiceLine();

        //ed >> ing
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_pillow_ed_ing_end");
        recievingRhyme = "ed";
        endingRhyme = "ing";
        firstSubtitles = "She used to hide things in her bed. Maybe a sock, shirt or even the remote.";
        secondSubtitles = "One time she hid her father’s coat. He went around looking for it that whole evening.";
        timeToSplit = 5.5f;
        keyWord = "keyword";
        AddVoiceLine();

        //ing >> ly
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_pillow_ing_ly_end");
        recievingRhyme = "ing";
        endingRhyme = "ly";
        firstSubtitles = "Lily didn’t like sleeping. She would rather stay awake all night,";
        secondSubtitles = "after all she did have her light. Even though she tackled the dark fearlessly.";
        timeToSplit = 4.4f;
        keyWord = "keyword";
        AddVoiceLine();



        ///////////////////////////////////////////////////// tv

        //ly >> ed
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_tv_ly_ed_end");
        recievingRhyme = "ly";
        endingRhyme = "ed";
        firstSubtitles = "Lily’s TV used to glow brightly.";
        secondSubtitles = "Brightly with the glow of her favorite show. The show was called “A Tailor’s Thread”.";
        timeToSplit = 2.2f;
        keyWord = "keyword";
        AddVoiceLine();

        //ed >> ing
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_tv_ed_ing_end");
        recievingRhyme = "ed";
        endingRhyme = "ing";
        firstSubtitles = "Lily’s favorite show was called “A Tailor’s Thread” She watched it every Friday afternoon";
        secondSubtitles = "It was about a girl with powers from the moon. She loved it even if some scenes were shocking.";
        timeToSplit = 5.6f;
        keyWord = "keyword";
        AddVoiceLine();

        //ing >> ly
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_tv_ing_ly_end");
        recievingRhyme = "ing";
        endingRhyme = "ly";
        firstSubtitles = "Lily was always watching. Watching her TV and movies when she wasn’t busy drawing.";
        secondSubtitles = "Her favorite movies were always kind of silly.";
        timeToSplit = 4.8f;
        keyWord = "keyword";
        AddVoiceLine();



        ///////////////////////////////////////////////////// painting transition

        //ly >> ed
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_field_ly_ed_end");
        recievingRhyme = "ly";
        endingRhyme = "ed";
        firstSubtitles = "A field of flowers she had remembered so fondly.";
        secondSubtitles = "It must have changed alot since she last visited.";
        timeToSplit = 3.2f;
        keyWord = "keyword";
        AddVoiceLine();

        //ed >> ing
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_field_ed_ing_end");
        recievingRhyme = "ed";
        endingRhyme = "ing";
        firstSubtitles = "Lily was proud of the picture she had painted.";
        secondSubtitles = "It was a picture of a field she had visited on her last spring.";
        timeToSplit = 3.6f;
        keyWord = "keyword";
        AddVoiceLine();

        //ing >> ly
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_field_ing_ly_end");
        recievingRhyme = "ing";
        endingRhyme = "ly";
        firstSubtitles = "An open field was the best place for running.";
        secondSubtitles = "With plains of grass that grew endlessly.";
        timeToSplit = 3.8f;
        keyWord = "keyword";
        AddVoiceLine();


        ///////////////////////////////////////////////////// mouse puzzle

        //ly >> ed
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_mouse_ly_ed_end");
        recievingRhyme = "ly";
        endingRhyme = "ed";
        firstSubtitles = "Lily always treated animals kindly.";
        secondSubtitles = "Especially the mice that lived under the shed.";
        timeToSplit = 2.2f;
        keyWord = "keyword";
        AddVoiceLine();

        //ed >> ing
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_mouse_ed_ing_end");
        recievingRhyme = "ed";
        endingRhyme = "ing";
        firstSubtitles = "Lily took care of the mice that lived under the shed.";
        secondSubtitles = "Taking care of animals was her second favorite thing.";
        timeToSplit = 2.6f;
        keyWord = "keyword";
        AddVoiceLine();

        //ing >> ly
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_mouse_ing_ly_end");
        recievingRhyme = "ing";
        endingRhyme = "ly";
        firstSubtitles = "Lily loved any cute little thing.";
        secondSubtitles = "Being a mouse was no exception to being treated kindly.";
        timeToSplit = 2.8f;
        keyWord = "keyword";
        AddVoiceLine();



        ///////////////////////////////////////////////////// rocket puzzle


        //ly >> ed
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_rocket_ly_ed_end");
        recievingRhyme = "ly";
        endingRhyme = "ed";
        firstSubtitles = "When Lily grew up she wanted to be an astronaut exploring the galaxy.";
        secondSubtitles = "She pretended to walk on planets she would have discovered.";
        timeToSplit = 2.2f;
        keyWord = "keyword";
        AddVoiceLine();

        //ed >> ing
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_rocket_ed_ing_end");
        recievingRhyme = "ed";
        endingRhyme = "ing";
        firstSubtitles = "She would fly across the night sky with the rockets fired.";
        secondSubtitles = "Down on the distant surface she’d be looking.";
        timeToSplit = 2.6f;
        keyWord = "keyword";
        AddVoiceLine();

        //ing >> ly
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_rocket_ing_ly_end");
        recievingRhyme = "ing";
        endingRhyme = "ly";
        firstSubtitles = "Playing astronauts never got tiring.";
        secondSubtitles = "Exploring new universes all across the galaxy.";
        timeToSplit = 2.8f;
        keyWord = "keyword";
        AddVoiceLine();



        ///////////////////////////////////////////////////// wheelbarrow puzzle

        //ly >> ed
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_wheel_ly_ed_end");
        recievingRhyme = "ly";
        endingRhyme = "ed";
        firstSubtitles = "She would often spend time in the garden with her mother only.";
        secondSubtitles = "She took care of her very own Lily she had planted.";
        timeToSplit = 2.2f;
        keyWord = "keyword";
        AddVoiceLine();

        //ed >> ing
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_wheel_ed_ing_end");
        recievingRhyme = "ed";
        endingRhyme = "ing";
        firstSubtitles = "Their garden had a big pretty flower bed.";
        secondSubtitles = "Lily often helped out with the gardening.";
        timeToSplit = 2.6f;
        keyWord = "keyword";
        AddVoiceLine();

        //ing >> ly
        voiceLine = Resources.Load<AudioClip>("Sounds/Narrator/narr_wheel_ing_ly_end");
        recievingRhyme = "ing";
        endingRhyme = "ly";
        firstSubtitles = "She often helped her mother with the gardening.";
        secondSubtitles = "It was a nice way to spend some time with her mother only";
        timeToSplit = 2.8f;
        keyWord = "keyword";
        AddVoiceLine();

    }
    private void AddVoiceLine()
    {
        NarratorHandler.Instance.NarrVoiceLineList.Add(new NarratorVoiceLine(voiceLine, keyWord, recievingRhyme, endingRhyme, timeToSplit, firstSubtitles, secondSubtitles));
        if (voiceLine == null)
        {
            Debug.LogError("Couldn't find narr_" + keyWord + "_" + recievingRhyme + "_" + endingRhyme);
            Debug.LogError(firstSubtitles);
        }
    }
}
