using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   public float speed = 150;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (JoystickInput.Right)
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0, 0, -90);
        }
        if (JoystickInput.Left)
        {
            transform.position += -Vector3.right * speed * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0, 0, 90);
        }
        if (JoystickInput.Up)
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        if (JoystickInput.Down)
        {
            transform.position += -Vector3.up * speed * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0, 0, 180);
        }
    }
}
