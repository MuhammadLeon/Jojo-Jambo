using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FillStatusBar : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public Image fillImage;
    private Slider slider;

    
    void Awake()
    {
        slider = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (slider.value <= slider.minValue)
        {
            fillImage.enabled = false;
        }

        if (slider.value > slider.minValue && fillImage.enabled)
        {
            fillImage.enabled = true;
        }

        float fillvalue = playerHealth.currentHealth / playerHealth.maxHealth;
        if(fillvalue <= slider.maxValue / 3)
        {
            fillImage.color = Color.white;
        }
        else if(fillvalue > slider.maxValue / 3)
        {
            fillImage.color = Color.red;
        }

        slider.value = fillvalue;
    }
}
