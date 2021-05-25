using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using LTAUnityBase.Base.Controller;

public class TimeController : MonoBehaviour
{
    [SerializeField]
    Slider slider;
    public int gameTime;
    float curentTime;

    void Start()
    {
        curentTime = gameTime;
        slider.maxValue = gameTime;
        slider.value = gameTime;
    }

    void Update()
    {
        if (JoystickInput.stopTimer == true)
        {
            Debug.Log("Pause or quit game");
            return;
        }
        else
        {
            curentTime = curentTime - Time.deltaTime;
            slider.value = curentTime;
            if (curentTime <= 0)
            {
                JoystickInput.stopTimer  = true;
            }
        }
         
         
          

    }
}
