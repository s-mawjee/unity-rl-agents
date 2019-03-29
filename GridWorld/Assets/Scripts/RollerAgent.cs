using UnityEngine;
using MLAgents;

public class RollerAgent : Agent
{
    Renderer targetRender;

    Rigidbody rBody;
    public Transform Target;
    public GameObject Key;
    public float speed = 10;
    private int collectedKey = 0;

    void Start()
    {
        rBody = GetComponent<Rigidbody>();
        targetRender = Target.gameObject.GetComponent<Renderer>();
    }

    public override void AgentReset()
    {

        // If the Agent fell, zero its momentum
        this.rBody.angularVelocity = Vector3.zero;
        this.rBody.velocity = Vector3.zero;
        this.transform.position = new Vector3(2, 0.5f, 2);

        // // Move the target to a new spot
        // Target.position = new Vector3(15, 0.01f, 15);
        targetRender.material.color = Color.red;
        collectedKey = 0;
        Key.SetActive(true);

    }

    public override void CollectObservations()
    {
        // // Target, Key and Agent positions
        //AddVectorObs(Target.position);
        //AddVectorObs(Key.position);
        AddVectorObs(this.transform.position);

        // State of key collection
        AddVectorObs(this.collectedKey);

        // Agent velocity
        AddVectorObs(rBody.velocity.x);
        AddVectorObs(rBody.velocity.z);
    }


    public override void AgentAction(float[] vectorAction, string textAction)
    {
        // Actions, size = 2
        Vector3 controlSignal = Vector3.zero;
        controlSignal.x = vectorAction[0];
        controlSignal.z = vectorAction[1];
        rBody.AddForce(controlSignal * speed);

        // Rewards
        float distanceToTarget = Vector3.Distance(this.transform.position,
                                                  Target.position);

        // Reached target
        if (collectedKey > 0 && distanceToTarget < 1.42f)
        {
            SetReward(1.0f);
            Done();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Key"))
        {
            other.gameObject.SetActive(false);
            collectedKey = 1;
            targetRender.material.color = Color.green;
        }
    }
}

