using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickOAOScript : MonoBehaviour
{
    public float currentValue = 0;
    public float minusValue = 0;
    public float plusValue;
    public float sliderValue;

    private void Update()
    {
        if (currentValue < 0) 
        {
            currentValue = 0;
        }

        if (currentValue > 1) 
        {
            currentValue = 1;
        }
        currentValue = currentValue - (minusValue * Time.deltaTime);

        sliderValue = currentValue;
        
    }

    public void plus()    
    {
        currentValue += plusValue;
    }
}
