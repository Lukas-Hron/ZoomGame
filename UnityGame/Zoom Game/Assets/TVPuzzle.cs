using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TVPuzzle : MonoBehaviour
{
    int currentChannel = 0;
    public List<GameObject> channels;
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

        if (currentChannel % channels.Count == 0)
            currentChannel = 0;

        DisplayChannel();
    }
    public void LastChannel()
    {
        AudioHandler.Instance.PlaySoundEffect(channelSwitch);
        currentChannel--;

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
