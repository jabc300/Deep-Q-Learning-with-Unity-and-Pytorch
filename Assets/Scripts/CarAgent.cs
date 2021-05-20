using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.MLAgents;
using Unity.MLAgents.Actuators;

public class CarAgent : Agent
{
    public float SteerForce, MotorForce;
    public Transform initialPosition;
    public WheelCollider FR_L_Wheel, FR_R_Wheel, RE_L_Wheel, RE_R_Wheel;
    public override void OnEpisodeBegin()
    {
        transform.position = initialPosition.position;
        transform.eulerAngles = new Vector3(0, 90, 0);
    }

    public override void OnActionReceived(ActionBuffers actions)
    {
        int selection = actions.DiscreteActions[0];
        float h;
        float v = -MotorForce;

        /*Actions in selection
         0: Don't steer, go straight
         1: Steer to the right
         2: Steer to the left
         */

        Debug.Log(actions.DiscreteActions[0]);

        if(selection <= 1)
        {
            h = selection;
        }else
        {
            h = -1;
        }

        RE_R_Wheel.motorTorque = v;
        RE_L_Wheel.motorTorque = v;

        FR_L_Wheel.steerAngle = h * SteerForce;
        FR_R_Wheel.steerAngle = h * SteerForce;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Target"))
        {
            SetReward(+1f);
        }
        if (other.gameObject.CompareTag("Wall"))
        {
            SetReward(-5f);
            EndEpisode();
        }
        if (other.gameObject.CompareTag("Goal"))
        {
            SetReward(+5f);
            EndEpisode();
        }
    }
}
