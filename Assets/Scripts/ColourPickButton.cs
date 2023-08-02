using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ColourPickButton : MonoBehaviour
{
    public UnityEvent<Color> ColorPickerEvent;
    [SerializeField] Texture2D colorChart;
    [SerializeField] GameObject chart;
    [SerializeField] RectTransform cursor;
    [SerializeField] Image button;
    [SerializeField] Image cursorColor;

    public RectTransform colorChartRect;
    public Color pickedColor;
    public void PickColor(BaseEventData data)
    {
        PointerEventData pointer = data as PointerEventData;
        cursor.position = pointer.position;
        Vector2 cursorRealPosition = new Vector2(colorChartRect.rect.width / 2 + cursor.localPosition.x, colorChartRect.rect.height / 2 + cursor.localPosition.y);
        pickedColor = colorChart.GetPixel((int)(cursorRealPosition.x * (colorChart.width / colorChartRect.rect.width)), (int)(cursorRealPosition.y * (colorChart.height / colorChartRect.rect.height))); 
        button.color = pickedColor;
        cursorColor.color = pickedColor;
        ColorPickerEvent.Invoke(pickedColor);
    }
}
