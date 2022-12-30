using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomHandler : MonoBehaviour
{
    Player player;
    CutsceneManager cutscene;
    public bool isZoom = false; //Updates Scaling of all active layers when enabled
    Vector2 mousePos; // Mouse position in game coordinates
    [SerializeField] public float smoothZoom = 0.1f; //How smooth the zoom should be
    [SerializeField] private float zoomSpeed = 0.2f; //How far you zoom with each scroll
    float zoomInMultiplier = 0.7f;
    public float zoomValue = -1; //Target ZoomLevel
    public float currentZoomValue = -1;
    public Transform lockedZoomOrigin;
    public List<GameObject> ZoomLayers; //Current layers loaded in

    [SerializeField] public float zoomMin, zoomMax;
    public float hotSpotMax;
    ZoomLayerHandler zoomLayerHandler;
    void Start()
    {
        player = GetComponent<Player>();
        cutscene = GetComponent<CutsceneManager>();
        ZoomLayers = new List<GameObject>();
        zoomLayerHandler = GetComponent<ZoomLayerHandler>();
        isZoom = true;
        zoomMax = 10;
        zoomMin = -5;

    }

    void Update()
    {
        // Check if the mouse scroll wheel is moved and the left mouse button is not pressed
        // and the player is allowed to zoom and input
        if (Input.mouseScrollDelta != Vector2.zero && !Input.GetMouseButton(0) && player.canZoom && player.canInput)
        {
            // If the player is not locked to a specific zoom position, use the current mouse position
            if (!player.isLockedZoom)
            {
                mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            }
            // Otherwise, use the locked zoom origin position
            else
            {
                mousePos = lockedZoomOrigin.position;
            }
            isZoom = true;
            player.isZooming = true;
        }

        // If the player is in a cutscene, use the cutscene origin position as the zoom target
        // and the resulting zoom value from the cutscene as the zoom level
        else if (player.inCutscene)
        {
            mousePos = cutscene.cutsceneOrigin.position;
            isZoom = true;
            zoomValue = cutscene.resultingZoomValue;
            currentZoomValue = zoomValue;
        }
        else if (player.canOnlyZoomIn)
        {
            mousePos = lockedZoomOrigin.position;
            isZoom = true;
        }

        // If the isZoom flag is set, move to the zoom level and check the current zoom level
        if (isZoom)
        {
            MoveToZoomLevel();
            zoomLayerHandler.CheckZoomLevel();
        }
    }


    void MoveToZoomLevel()
    {
        for (var i = 0; i < ZoomLayers.Count; i++)
        {
            float layerZoom = currentZoomValue - ZoomLayers[i].GetComponent<Layer>().size;
            layerZoom = Mathf.Exp(layerZoom);
            ScaleAround(ZoomLayers[i], new Vector3(mousePos.x, mousePos.y, 0), new Vector3(layerZoom, layerZoom, 1));

            if (i > 0)
            {
                ZoomLayers[i].transform.position = ZoomLayers[i - 1].GetComponent<Layer>().nextLayerPos.position;
            }
        }

        if (!player.canOnlyZoomIn)
        {
            if (Input.mouseScrollDelta.y < 0) //Check if zooming in or out. Zooming in will be slower.
                zoomValue = (Input.mouseScrollDelta.y * zoomSpeed) + zoomValue;
            else
                zoomValue = (Input.mouseScrollDelta.y * zoomSpeed * zoomInMultiplier) + zoomValue;
        }
        else
        {
            if (Input.mouseScrollDelta.y > 0)
            {
                zoomValue = (Input.mouseScrollDelta.y * zoomSpeed * zoomInMultiplier) + zoomValue;
            }
        }


        if (hotSpotMax <= zoomMax)
            zoomValue = Mathf.Clamp(zoomValue, zoomMin, zoomMax); //Clamp zoom value
        else
            zoomValue = Mathf.Clamp(zoomValue, zoomMin, hotSpotMax); //Clamp zoom value when in hotspot

        currentZoomValue = Mathf.SmoothStep(currentZoomValue, zoomValue, smoothZoom);

        if (Mathf.Abs(currentZoomValue - zoomValue) < 0.01)
        {
            isZoom = false;
            player.isZooming = false;
        }

    }

    public void ScaleAround(GameObject target, Vector3 pivot, Vector3 newScale)
    {
        Vector3 A = target.transform.localPosition;
        Vector3 B = pivot;

        Vector3 C = A - B; // diff from object pivot to desired pivot/origin

        float RS = newScale.x / target.transform.localScale.x; // relataive scale factor

        // calc final position post-scale
        Vector3 FP = B + C * RS;

        // finally, actually perform the scale/translation
        target.transform.localScale = newScale;
        target.transform.localPosition = FP;
    }

    public void RealignZoomlayers()
    {
        for (var i = 0; i < ZoomLayers.Count; i++) //Loop over every layer and align it correctly
        {
            float layerZoom = currentZoomValue - ZoomLayers[i].GetComponent<Layer>().size;
            layerZoom = Mathf.Exp(layerZoom);
            ZoomLayers[i].transform.localScale = new Vector3(layerZoom, layerZoom, 1);

            if (i > 0)
            {
                ZoomLayers[i].transform.position = ZoomLayers[i - 1].GetComponent<Layer>().nextLayerPos.position;
            }
        }
    }
}

