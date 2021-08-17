using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleSlider : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToggleSliderValue(Slider slider)
    {
        if(slider.value == slider.minValue)
        {
            slider.value = 0;
            return;
        }

        slider.value = slider.minValue;
    }
}