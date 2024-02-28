using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class CCTVCameraController : MonoBehaviour
{
    
    public float turnSpeed = 5f;

    
    public float turnAngle = 90;

    
    bool turningRight = true;

    
    void Start()
    {

    }

    
    void Update()
    {
        if (turningRight)
        {
            TurnRight();
        }
        else
        {
            TurnLeft();
        }
        CheckAngle();
    }
    void TurnRight()
    {
        
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed);
    }
    void TurnLeft()
    {
       
        transform.Rotate(Vector3.down * Time.deltaTime * turnSpeed);
    }
    void CheckAngle()
    {
       
        if (transform.eulerAngles.y > 45)
        {
            
            turningRight = false;
        }
        if (transform.eulerAngles.y < 315)
        {
            
            turningRight = true;
        }
        Debug.Log("y: " + transform.eulerAngles.y + "turningRight: " + turningRight);
    }
}