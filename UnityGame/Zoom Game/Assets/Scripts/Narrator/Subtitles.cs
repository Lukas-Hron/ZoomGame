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
        canvasSubtitle = GameObject.Find("canvasSubtitles");
        enabledSubtitle = !enabledSubtitle;
        if (enabledSubtitle)
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
    public void playSubtitle(string subTitle, float timer)
    {
        if (enabledSubtitle)
        {
           if (startSubtitle == false)
            {
                canvasSubtitle.GetComponent<TextMeshProUGUI>().text = subTitle;
                currentSubtitleTimer = 0;
                targetSubtitleTimer = timer;
                startSubtitle = true;
            }
        }
    }

    public void cutUpSubtitle(string stringen, float totalTime)
    {
        string[] splittedString = stringen.Split('.');
        
       
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
}
