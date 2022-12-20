using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TVPuzzle : MonoBehaviour
{
    int currentChannel = 0;
    int rickRollCounter = 0;
    public List<GameObject> channels;
    [SerializeField] GameObject rickRoll;
    [SerializeField] AudioClip tvOn, channelSwitch;
    // Start is called before the first frame update

    public void TurnOnTV()
    {
        AudioHandler.Instance.PlaySoundEffect(tvOn);

        DisplayChannel();
    }

    public void TurnOffTv()
    {
        foreach (GameObject chan in channels)
        {
            chan.SetActive(false);
        }
    }

    public void NextChannel()
    {
        AudioHandler.Instance.PlaySoundEffect(channelSwitch);
        currentChannel++;
        rickRollCounter++;

        if (currentChannel % channels.Count == 0)
            currentChannel = 0;

        DisplayChannel();
        if (rickRollCounter % 25 == 0)
        {
            foreach (GameObject chan in channels)
            {
                chan.SetActive(false);
            }
            rickRoll.SetActive(true);
        }
        else 
            rickRoll.SetActive(false);
    }
    public void LastChannel()
    {
        AudioHandler.Instance.PlaySoundEffect(channelSwitch);
        currentChannel--;
        rickRollCounter++;


        if (currentChannel % channels.Count == -1)
            currentChannel = channels.Count - 1;

        DisplayChannel();
    }

    private void DisplayChannel()
    {
        foreach (GameObject chan in channels)
        {
            chan.SetActive(false);
        }
        channels[currentChannel].SetActive(true);
    }
}
