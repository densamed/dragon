#pragma strict

var projectile: Rigidbody2D;
var speed = 20;
var  timeDestroy = 1;

function Update () 
{

	if ( Input.GetMouseButtonDown(0))
	{

		var clone = Instantiate(projectile, transform.position, transform.rotation);
		clone.velocity = transform.TransformDirection( Vector3 (0, 0, speed));
	
		Destroy (clone.gameObject, timeDestroy);

	}
}