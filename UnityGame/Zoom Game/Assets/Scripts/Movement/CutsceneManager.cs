using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutsceneManager : MonoBehaviour
{
    [SerializeField] AnimationCurve curve;
    public Player player;
    public ZoomHandler zoom;
    public Transform cutsceneOrigin;
    public float zoomValue;
    [SerializeField] float targetZoomValue;
    float zoomLerp;
    float panLerp;
    bool finishPan = false;
    bool hasAssignedOrigin;
    public float resultingZoomValue;
    public float duration = 5f;

    private void Start()
    {
        player = GetComponent<Player>();
        zoom = GetComponent<ZoomHandler>();
    }

    private void Update()
    {

        if (player.inCutscene)
        {
            if (!hasAssignedOrigin)
            {
                cutsceneOrigin = FindObjectOfType<cursceneorigin>().transform;
                zoomValue = zoom.currentZoomValue;
                resultingZoomValue = zoomValue;

                hasAssignedOrigin = true;
            }

            PlayCutscene();
        }
    }
    private void PlayCutscene()
    {
        if (finishPan)
        {
            zoomLerp += Time.deltaTime / (duration-1);
            resultingZoomValue = Mathf.Lerp(zoomValue, targetZoomValue,curve.Evaluate(zoomLerp));


            if (resultingZoomValue == targetZoomValue)
            {
                zoom.currentZoomValue = targetZoomValue;
            }

        }
        else
        {
            panLerp += Time.deltaTime;
            Vector3 cameraPos = Vector2.Lerp(Camera.main.transform.position, cutsceneOrigin.position, panLerp);
            cameraPos.z = -10;
            Camera.main.transform.position = cameraPos;

            if (panLerp >= 1)
            {
                finishPan = true;
            }
        }
    }
}
