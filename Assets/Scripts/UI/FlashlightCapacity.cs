﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class FlashlightCapacity : MonoBehaviour
{
    [SerializeField]
    GameObject section1, section2, section3, section4, section5;
    [SerializeField]
    Text percentageText;
    [SerializeField]
    FlashLightInput flashLightInput;

    private int currentBatteryPercentage;

    void Awake()
    {
        section5.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        // Updates percentage value
        currentBatteryPercentage = flashLightInput.CurrentChargePercentageRemaining;
        
        BatterySectionManagement();

    }

    private void BatterySectionManagement()
    {
        switch (currentBatteryPercentage)
        {
            // After reloading turns all sections ON
            case 100:
                section1.SetActive(true);
                section2.SetActive(true);
                section3.SetActive(true);
                section4.SetActive(true);
                section5.SetActive(false);
                break;
            
            // 1st Section OFF
            case 75:
                section1.SetActive(false);
                break;
            
            // 2nd Section OFF
            case 50:
                section2.SetActive(false);
                break;
            
            // 3rd Section OFF
            case 25:
                section5.SetActive(true);
                section3.SetActive(false);
                break;
            
            //4th Section OFF
            case 0:
                section4.SetActive(false);
                section5.SetActive(false);
                break;
        }
        
    }
    
    
}
