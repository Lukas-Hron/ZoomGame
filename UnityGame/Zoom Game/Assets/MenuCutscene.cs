using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuCutscene : MonoBehaviour
{
    public bool startCutscene= false;
    ZoomHandler zoom;
    float targetZoom = 8.5f;
    float lerpLevel;
    public AnimationCurve curve;
    // Start is called before the first frame update
    void Start()
    {
        zoom = Object.FindObjectOfType<ZoomHandler>();
    }

    // Update is called once per frame
    void Update()
    {
        if (startCutscene)
        {
            Step();
        }
    }

    public void Step()
    {
        lerpLevel += Time.deltaTime / 5;
        zoom.currentZoomValue = Mathf.Lerp(-1f, targetZoom, curve.Evaluate(lerpLevel));
        zoom.zoomValue = zoom.currentZoomValue; 
        zoom.isZoom = true;
        if (lerpLevel>1)
        {
            zoom.hasControl = true;
            startCutscene = false;
            zoom.zoomMin = targetZoom;
            zoom.SetZoomClamp(targetZoom, 0);

        }

    }
}
