using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class Subtitles : MonoBehaviour
{
    public GameObject canvasSubtitle;
    public GameObject menuToggleButton;
    public Button button;
    public Sprite toggleOn;
    public Sprite toggleOff;
    public bool enabledSubtitle = true;
    public bool startSubtitle = false;

    public float currentSubtitleTimer;
    public float targetSubtitleTimer;
    string secondString;
    float fullTimer;
    float splitTimer;

    public void toggleSubtitle()
    {
        enabledSubtitle = !enabledSubtitle;
        if (!enabledSubtitle)
        {
            button.image.sprite = toggleOff;
            canvasSubtitle.SetActive(false);
        }
        else
        {
            button.image.sprite = toggleOn;
            canvasSubtitle.SetActive(true);
        }
    }
    public void playSubtitle(string firstSub,string secondSub, float fullTimer,float splitTime)
    {
        secondString = secondSub;
        this.fullTimer = fullTimer;
        splitTimer = splitTime;
        if (enabledSubtitle)
        {
            if (startSubtitle == false)
            {
                canvasSubtitle.GetComponent<TextMeshProUGUI>().text = firstSub;
                currentSubtitleTimer = 0;
                targetSubtitleTimer = splitTime;
                startSubtitle = true;
                Invoke(methodName: "PlaySecondString", splitTime + 0.25f);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (startSubtitle)
        {
            if (currentSubtitleTimer < targetSubtitleTimer) currentSubtitleTimer += Time.deltaTime;
            else
            {
                canvasSubtitle.GetComponent<TextMeshProUGUI>().text = "";
                startSubtitle = false;

            }
        }

    }


    private void PlaySecondString()
    {
        if (enabledSubtitle)
        {
            if (startSubtitle == false)
            {
                canvasSubtitle.GetComponent<TextMeshProUGUI>().text = secondString;
                currentSubtitleTimer = 0;
                targetSubtitleTimer = fullTimer-splitTimer;
                startSubtitle = true;
            }
        }
    }
}