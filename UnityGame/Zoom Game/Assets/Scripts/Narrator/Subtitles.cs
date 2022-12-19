using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Subtitles : MonoBehaviour
{
    public GameObject canvasSubtitle;
    public GameObject menuToggleButton;
    Button button;
    public Sprite toggleOn;
    public Sprite toggleOff;
    public bool enabledSubtitle = true;
    public bool startSubtitle = false;

    public float currentSubtitleTimer;
    public float targetSubtitleTimer;

    public void Start()
    {
        button = GetComponent<Button>();
    }

    public void toggleSubtitle()
    {
        enabledSubtitle = !enabledSubtitle;
        if (enabledSubtitle)
        {
            button.image.sprite = toggleOff;
        }
        else button.image.sprite = toggleOn;
    }
    public void playSubtitle(string subTitle, float timer)
    {
        if (enabledSubtitle)
        {
           if (startSubtitle == false)
            {
                canvasSubtitle.GetComponent<TextMeshPro>().text = subTitle;
                currentSubtitleTimer = 0;
                targetSubtitleTimer = timer;
                startSubtitle = true;
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
                canvasSubtitle.GetComponent<TextMeshPro>().text = "";
                startSubtitle = false;

            }
        }

    }
}
