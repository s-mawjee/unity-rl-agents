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

        float x = Normalise(this.transform.position.x, 0, 20);
        AddVectorObs(x);
        float y = Normalise(this.transform.position.y, 0, 1);
        AddVectorObs(y);
        float z = Normalise(this.transform.position.z, 0, 20);
        AddVectorObs(z);
        Monitor.Log("X", x.ToString(), null);
        Monitor.Log("Y", y.ToString(), null);
        Monitor.Log("Z", z.ToString(), null);

        // State of key collection
        AddVectorObs(this.collectedKey);

        Monitor.Log("Collected Key", (this.collectedKey == 1).ToString(), null);

        // // Agent velocity
        // AddVectorObs(rBody.velocity.x);
        // AddVectorObs(rBody.velocity.z);

        // Monitor.Log("Velocity X", rBody.velocity.x.ToString(), null);
        // Monitor.Log("Velocity Z", rBody.velocity.z.ToString(), null);

    }

    private float Normalise(float currentValue, float minValue = 0, float maxValue = 20)
    {
        return (currentValue - minValue) / (maxValue - minValue);
    }


    public override void AgentAction(float[] vectorAction, string textAction)
    {
        // Actions, size = 2
        Vector3 controlSignal = Vector3.zero;

        controlSignal.x = 0;
        controlSignal.y = 0;
        controlSignal.z = 0;

        int action = int.Parse(vectorAction[0].ToString());

        if (vectorAction[0] > 0)
        {
            if (action == 1)
            {
                controlSignal.x = -1;
            }
            else if (action == 2)
            {
                controlSignal.x = 1;
            }
            else if (action == 3)
            {
                controlSignal.z = -1;
            }
            else if (action == 4)
            {
                controlSignal.z = 1;
            }
        }
        rBody.AddForce(controlSignal * speed);



        // Rewards
        float distanceToTarget = Vector3.Distance(this.transform.position,
                                                  Target.position);

        // Reached target
        if (collectedKey > 0 && distanceToTarget < 1.42f)
        {
            SetReward(10.0f);
            Done();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Key"))
        {
            other.gameObject.SetActive(false);
            collectedKey = 1;
            SetReward(1.0f);
            targetRender.material.color = Color.green;
        }
    }
}

