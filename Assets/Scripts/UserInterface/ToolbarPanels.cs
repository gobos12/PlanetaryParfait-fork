using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class ToolbarPanels : MonoBehaviour
{
    [Header("Per Pixel Tool")]
    public RectTransform perPixelPanel;
    public Transform perPixelButtonTransform;
    public Vector2 perPixelDesktop;
    public Vector3 perPixelVR;

    [Header("Scalebar Tool")] 
    public RectTransform scalebarPanel;
    public Transform scalebarButtonTransform;
    public Vector2 scalebarDesktop;
    public Vector3 scalebarVR;

    [Header("Layers Tool")]
    public RectTransform layersPanel;
    public Vector2 layersDesktop;
    public Vector3 layersVR;

    [Header("Color Picker Tool")]
    public RectTransform colorPickerPanel;
    public Vector2 colorPickerDesktop;
    public Vector3 colorPickerVR;

    [Header("Room Code")] 
    public RectTransform roomCodePanel;
    public Vector2 roomCodeDesktop;
    public Vector3 roomCodeVR;
    
    void Start()
    {
        print("1. " + colorPickerPanel.transform.position);
        print("2. " + colorPickerPanel.transform.localPosition);
        print("3. " + colorPickerPanel.anchoredPosition);
        
        if (GameState.IsVR)
        {
            perPixelPanel.transform.parent = perPixelButtonTransform;
            scalebarPanel.transform.parent = scalebarButtonTransform;
            colorPickerPanel.transform.parent = scalebarButtonTransform;
        }

        perPixelPanel.anchoredPosition = GameState.IsVR ? perPixelVR : perPixelDesktop;
        scalebarPanel.anchoredPosition = GameState.IsVR ? scalebarVR : scalebarDesktop;
        layersPanel.anchoredPosition = GameState.IsVR ? layersVR : layersDesktop;
        colorPickerPanel.anchoredPosition = GameState.IsVR ? colorPickerVR : colorPickerDesktop;
        roomCodePanel.anchoredPosition = GameState.IsVR ? roomCodeVR : roomCodeDesktop;
    }
}
