using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SoundSettings : MonoBehaviour
{
    public Slider slider;
    public AudioMixer audioMixer;
    public string groupName;
    [SerializeField] private Image muteImage;
    private MuteIconSwap iconSwapping;

    private void Awake()
    {
        audioMixer.GetFloat(groupName, out var value);
        slider.value = value;
        iconSwapping = GameObject.FindGameObjectWithTag("UISounds").GetComponent<MuteIconSwap>();

        if(slider.value == slider.minValue)
        {
            iconSwapping.Mute(muteImage);
        }

        else if(slider.value != slider.minValue) 
        {
            iconSwapping.Unmute(muteImage);
        }
    }

    private void OnEnable()
    {
        slider.onValueChanged.AddListener(SliderValueChanged);
    }

    private void OnDisable()
    {
        slider.onValueChanged.RemoveListener(SliderValueChanged);
    }

    private void SliderValueChanged(float value)
    {
        audioMixer.SetFloat(groupName, value);

        if(slider.value == slider.minValue)
        {
            iconSwapping.Mute(muteImage);
        }

        else if(slider.value != slider.minValue) 
        {
            iconSwapping.Unmute(muteImage);
        }
    }
}