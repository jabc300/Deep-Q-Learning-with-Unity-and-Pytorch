using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float MotorForce;
    public WheelCollider RE_L_Wheel, RE_R_Wheel;
    // Update is called once per frame
    void FixedUpdate()
    {
        float v = -MotorForce;

        RE_R_Wheel.motorTorque = v;
        RE_L_Wheel.motorTorque = v;


        /*if(Input.GetAxis("Vertical") == 0)
        {
            RE_L_Wheel.brakeTorque = BrakeForce;
            RE_R_Wheel.brakeTorque = BrakeForce;
        }
        else
        {
            RE_L_Wheel.brakeTorque = 0;
            RE_R_Wheel.brakeTorque = 0;
        }*/
    }
}
