using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighlightObject : MonoBehaviour
{
    Renderer touchCurrentRenderer;
    Color touchOriginalColor;
    public Color touchHighlightColor;

    void OnTriggerStay(Collider other)
    {
        if (touchCurrentRenderer == null && other.tag == "Grabbable")
        {
            touchCurrentRenderer = other.GetComponent<Renderer>();
            if (touchCurrentRenderer != null)
            {
                touchOriginalColor = touchCurrentRenderer.material.color;
                touchCurrentRenderer.material.color = touchHighlightColor;
            }
        }
    }
    void OnTriggerExit(Collider other)
    {
        touchCurrentRenderer.material.color = touchOriginalColor;
        touchCurrentRenderer = null;
    }
}
