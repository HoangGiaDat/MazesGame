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
    bool stopTimer;
    float curentTime;

    void Start()
    {
        stopTimer = false;
        curentTime = gameTime;
        slider.maxValue = gameTime;
        slider.value = gameTime;
    }

    void Update()
    {
        
        if (curentTime <= 0)
        {
            stopTimer = true;
        }    
        if (stopTimer == false)
        {
            curentTime = curentTime - Time.deltaTime;
            slider.value = curentTime;
        }    
        if (stopTimer == true)
        {
            Debug.Log("Pause or quit game");
        }    

    }
}
