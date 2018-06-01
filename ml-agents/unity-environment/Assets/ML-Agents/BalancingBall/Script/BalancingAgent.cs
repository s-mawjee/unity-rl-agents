using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalancingAgent : Agent {

	public GameObject ball;
	Vector3 ballStartPosition;
	Quaternion plankStartRotation;

	void Start () {
		ballStartPosition = ball.transform.position;
		plankStartRotation = gameObject.transform.rotation;
    }

	public override void AgentAction(float[] actions, string textAction){

		gameObject.transform.Rotate(new Vector3(0,0,1), actions[0]);
		gameObject.transform.Rotate(new Vector3(1,0,0), actions[1]);

		if(IsDone() == false){
			AddReward(0.1f);
		}

		if((ball.transform.position.y - gameObject.transform.position.y) < -2f){
			Done();
			AddReward(-1f);
		}

	}

	public override void CollectObservations()
	{
		AddVectorObs(gameObject.transform.rotation.z);
		AddVectorObs(gameObject.transform.rotation.x);
		AddVectorObs((ball.transform.position.x -  gameObject.transform.position.x ));
		AddVectorObs((ball.transform.position.y -  gameObject.transform.position.y ));
		AddVectorObs((ball.transform.position.z -  gameObject.transform.position.z ));
		AddVectorObs(ball.transform.GetComponent<Rigidbody>().velocity.x);
		AddVectorObs(ball.transform.GetComponent<Rigidbody>().velocity.y);
		AddVectorObs(ball.transform.GetComponent<Rigidbody>().velocity.z);
	}

	 public override void AgentReset()
    {
        gameObject.transform.rotation =plankStartRotation;
		ball.GetComponent<Rigidbody>().velocity = new Vector3(0f,0f,0f);
		ball.transform.position = ballStartPosition;
    }
}
