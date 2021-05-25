using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickInput : MonoBehaviour
{
    public static bool Left
    {
        get
        {
            return JoyStick.Instance.direction.x < -0.95f ;
        }
    }
    public static bool Right
    {
        get
        {
            return JoyStick.Instance.direction.x > 0.95f;
        }
    }
    public static bool Up
    {
        get
        {
            return JoyStick.Instance.direction.y >=0.9f;
        }
    }

    public static bool Down
    {
        get
        {
            return JoyStick.Instance.direction.y <= -0.9f;
        }
    }
    public static bool stopTimer = false;
    
}
