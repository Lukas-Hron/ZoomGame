using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ZoomLayer
{
    public void disableZoomLayer();
    public void enableZoomLayer();
    public bool transissionForward();
    public Player updateZoomLayer(Player player);
}
