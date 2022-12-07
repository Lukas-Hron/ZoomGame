using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutsceneManager : MonoBehaviour
{
    [SerializeField] AnimationCurve curve;
    public Player player;
    public ZoomHandler zoom;
    public Vector2 cutsceneOrigin = Vector2.zero;
    public float zoomValue;
    [SerializeField] float targetZoomValue;
    float lerp;
     public float resultingZoomValue = 10;
    [SerializeField] float duration = 5f;

    private void Start()
    {
        player = GetComponent<Player>();
        zoom = GetComponent<ZoomHandler>();
    }
    private void Update()
    {
        if (player.inCutscene)
        {
            player.canInput = false;
            PlayCutscene();
        }
    }

    private void PlayCutscene()
    {
        lerp += Time.deltaTime / duration;
        resultingZoomValue = Mathf.Lerp(zoomValue, targetZoomValue,lerp);


        if (resultingZoomValue == targetZoomValue)
        {
            player.inCutscene = false;
            player.canInput = true;
            player.canZoom = true;
            player.canPan = true;
            zoom.zoomValue = targetZoomValue;
        }
    }
}
