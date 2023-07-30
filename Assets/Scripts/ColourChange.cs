using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ColourChange : MonoBehaviour
{
    public ColourPickButton colourPickButton;
    public LineRenderer lineRenderer;

    public void Start()
    {
        lineRenderer.SetColors(Color.black, Color.black);
    }
    public void Update()
    {
        lineRenderer.SetColors(colourPickButton.pickedColor, colourPickButton.pickedColor);
    }
}
