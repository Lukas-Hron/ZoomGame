using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Openurl : MonoBehaviour
{
    public string website;
    // Start is called before the first frame update
    public void OpenWebsite()
    {
        Application.OpenURL(website);
    }

    private void OnMouseDown()
    {
        OpenWebsite();
    }
}
