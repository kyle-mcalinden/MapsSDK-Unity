using System.Collections;
using System.Collections.Generic;
using System.Web;
using System.Linq;
using System.Globalization;
using Microsoft.Geospatial;
using Microsoft.Maps.Unity;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MapUiController : MonoBehaviour
{    
    public MapRenderer map;
    public TMP_InputField latInput;
    public TMP_InputField longInput;
    public Slider zoomSlider;

    public void InputChanges()
    {
        map.SetMapScene(new MapSceneOfLocationAndZoomLevel(new LatLon(ConvertToDouble(latInput.text), ConvertToDouble(longInput.text)), 20f));
    }

    public double ConvertToDouble(string input)
    {
        return double.Parse(input, CultureInfo.InvariantCulture);
    }
}
