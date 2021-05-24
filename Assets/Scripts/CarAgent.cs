using UnityEngine;
using Unity.MLAgents;
using Unity.MLAgents.Actuators;

public class CarAgent : Agent
{
    // -----------------------------------------------------------------------------------------------------------------

    #region VARIABLES

    /// <summary>
    /// Steer force.
    /// </summary>
    [Header("Movement")] [SerializeField] private float steerForce;

    /// <summary>
    /// Motor force.
    /// </summary>
    [SerializeField] private float motorForce;

    
    /// <summary>
    /// The starting position where the agent will start in each episode.
    /// </summary>
    [Header("Start position")] [SerializeField] private Transform initialPosition;

    
    /// <summary>
    /// WheelCollider component for the Wheel Front Left.
    /// </summary>
    [Header("Wheels")] [SerializeField] private WheelCollider wheelFrontLeft;

    /// <summary>
    /// WheelCollider component for the Wheel Front Right.
    /// </summary>
    [SerializeField] private WheelCollider wheelFrontRight;

    /// <summary>
    /// WheelCollider component for the Wheel Back Left.
    /// </summary>
    [SerializeField] private WheelCollider wheelBackLeft;

    /// <summary>
    /// WheelCollider component for the Wheel Back Right.
    /// </summary>
    [SerializeField] private WheelCollider wheelBackRight;

    /// <summary>
    /// Reference to this transform component.
    /// </summary>
    private Transform _transform;

    #endregion

    // -----------------------------------------------------------------------------------------------------------------

    #region Agent Methods

    /// <summary>
    /// Function that is called when starting a new episode and is responsible for restarting the agent.
    /// </summary>
    public override void OnEpisodeBegin()
    {
        _transform = transform;
        _transform.position = initialPosition.position;
        _transform.eulerAngles = new Vector3(0f, 90f, 0f);
    }


    /// <summary>
    /// Function that is in charge of determining the behavior depending on the actions it receives.
    /// Actions: 0: go straight | 1: Steer to the right | 2: Steer to the left.
    /// </summary>
    /// <param name="actions"></param>
    public override void OnActionReceived(ActionBuffers actions)
    {
        int action = actions.DiscreteActions[0];
        float h, v = -motorForce;

        if (action <= 1) h = action;
        else h = -1;

        wheelBackLeft.motorTorque = v;
        wheelBackRight.motorTorque = v;
        wheelFrontLeft.steerAngle = h * steerForce;
        wheelFrontRight.steerAngle = h * steerForce;
    }

    #endregion

    // -----------------------------------------------------------------------------------------------------------------

    #region Unity Collision Methods

    /// <summary>
    /// Function that is invoked when the physics engine detects a collision between two or more objects.
    /// </summary>
    /// <param name="other">An object that contains all the information about the collision.</param>
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Target"))
            SetReward(+1f);

        if (other.gameObject.CompareTag("Wall"))
        {
            SetReward(-5f);
            EndEpisode();
        }
    }

    #endregion

    // -----------------------------------------------------------------------------------------------------------------
}