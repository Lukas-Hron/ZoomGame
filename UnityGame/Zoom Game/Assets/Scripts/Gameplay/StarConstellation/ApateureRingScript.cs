using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApateureRingScript : MonoBehaviour
{
    public bool fstRingDone;
    public bool sndRingDone;
    public bool thrdRingDone;

    public GameObject path1;
    public GameObject path2;
    public GameObject path3;

    public GameObject apataturePart1;
    public GameObject apataturePart2;
    public GameObject apataturePart3;

    public Sprite activatedPath;
    public Sprite actiatedApaturePart;

    public Animator apatureRingAnimation;


    // Update is called once per frame
    void Update()
    {
        
    }

    public void checkRing(string ringName)
    {
        if (ringName == "fst")
        {
            fstRingDone = true;
            path1.GetComponent<SpriteRenderer>().sprite = activatedPath;
            apataturePart1.GetComponent<SpriteRenderer>().sprite = actiatedApaturePart;
        }
        else if (ringName == "snd")
        {
            sndRingDone = true;
            path2.GetComponent<SpriteRenderer>().sprite = activatedPath;
            apataturePart2.GetComponent<SpriteRenderer>().sprite = actiatedApaturePart;
        }
        else if (ringName == "thrd")
        {
            thrdRingDone = true;
            path3.GetComponent<SpriteRenderer>().sprite = activatedPath;
            apataturePart3.GetComponent<SpriteRenderer>().sprite = actiatedApaturePart;
        }

        if (fstRingDone && sndRingDone && thrdRingDone)
        {
            apatureRingAnimation.SetTrigger("win");
        }
    }
}
