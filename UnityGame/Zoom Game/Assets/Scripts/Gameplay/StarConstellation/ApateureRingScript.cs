using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApateureRingScript : MonoBehaviour
{
    public bool fstRingDone;
    public bool sndRingDone;
    public bool thrdRingDone;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void checkRing(string ringName)
    {
        if (ringName == "fst")
        {
            fstRingDone = true;
        }
        else if (ringName == "snd")
        {
            sndRingDone = true;
        }
        else if (ringName == "thrd")
        {
            thrdRingDone = true;
        }
    }
}
