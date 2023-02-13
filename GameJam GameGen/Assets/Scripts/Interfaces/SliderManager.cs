using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class SliderManager : MonoBehaviour
{
    [Header("Sensibilidad")]
    private FirstPersonCamera fpc;
    public TMP_InputField tmproTextSense;
    public Slider sliderSense;
    public float maxValue = 400;
    private string formatTextSense = "{0}";

    [Header("General")]
    public TMP_InputField tmproTextGeneral;
    public Slider sliderGeneral;
    private string formatTextGeneral = "{0}";

    [Header("Musica")]
    public TMP_InputField tmproTextMusica;
    public Slider sliderMusica;
    private string formatTextMusica = "{0}";

    [Header("SFX")]
    public TMP_InputField tmproTextSFX;
    public Slider sliderSFX;
    private string formatTextSFX = "{0}";

    void Start()
    {
        fpc = GameObject.Find("Player").GetComponentInChildren<FirstPersonCamera>();
        sliderSense.onValueChanged.AddListener(HandleValueChanged);
        sliderGeneral.onValueChanged.AddListener(HandleValueChangedGeneral);   
        sliderMusica.onValueChanged.AddListener(HandleValueChangedMusica);
        sliderSFX.onValueChanged.AddListener(HandleValueChangedSFX);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void HandleValueChanged(float value)
    {
        tmproTextSense.text = string.Format(formatTextSense, (int) value/8);
    }

    public void AjustSense(float sense)
    {
        fpc.mouseSense = sense;
    }

    public void editSlider(string value)
    {
        float newValue = float.Parse(value);
        newValue = Mathf.Clamp(newValue,1,maxValue);
        sliderSense.value = newValue;
    }

    public void HandleValueChangedGeneral(float value)
    {
        tmproTextGeneral.text = string.Format(formatTextGeneral, value*100);
    }

    public void editSliderGeneral(string value)
    {
        float newValue = float.Parse(value);
        newValue = Mathf.Clamp(newValue/100, 0.1f, 1);
        sliderGeneral.value = newValue;
    }

    public void HandleValueChangedMusica(float value)
    {
        tmproTextMusica.text = string.Format(formatTextMusica, value * 100);
    }

    public void editSliderMusica(string value)
    {
        float newValue = float.Parse(value);
        newValue = Mathf.Clamp(newValue / 100, 0.1f, 1);
        sliderMusica.value = newValue;
    }

    public void HandleValueChangedSFX(float value)
    {
        tmproTextSFX.text = string.Format(formatTextSFX, value * 100);
    }

    public void editSliderSFX(string value)
    {
        float newValue = float.Parse(value);
        newValue = Mathf.Clamp(newValue / 100, 0.1f, 1);
        sliderSFX.value = newValue;
    }

}
