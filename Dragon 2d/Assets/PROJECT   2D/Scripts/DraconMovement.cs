using UnityEngine;
using System.Collections;

public class DraconMovement : MonoBehaviour 
{

	Vector3 velocity = Vector3.zero;
	public Vector3 gravity;
	public Vector3 flapVelocity;
	public float maxSpeed = 5f;
	public float forwardSpeed;

	bool didFlap = false;

	// Use this for initialization
	void Start () 
	{
	
	}

	//Graphics and Input updates here
	void Update()
	{
		if (Input.GetKeyDown (KeyCode.Space) || Input.GetMouseButtonDown(0) )
		{
			didFlap = true;
		}
	}



	// do physics engine updates here
	void FixedUpdate () {
		velocity.x = forwardSpeed;
		velocity += gravity * Time.deltaTime;

		if(didFlap == true) 
		{
			didFlap= false;
			velocity += flapVelocity; 
		}

		velocity = Vector3.ClampMagnitude(velocity, maxSpeed);
		transform.position += velocity * Time.deltaTime;


//		float angle = 0;
//		if (velocity.y <0) 
//		{
//			 angle = Mathf.Lerp(5, -70, -velocity.y/ maxSpeed);
//		}
//
//		else if (velocity.y >= 0) 
//		{
//			angle = Mathf.Lerp(5, 67, velocity.y/ maxSpeed);
//		}
//		transform.rotation= Quaternion.Euler(0,0, angle);
	}
}
