#pragma strict

var maxFallDistance = 0;
var maxUpDistance = 40;



function Update () {


	
	

	if (transform .position.y < maxFallDistance)
	{
		
		Application.LoadLevel ("secret");
	}
	else if (transform .position.y > maxUpDistance)
	{
		
		Application.LoadLevel ("secret");
	}
	
	
	

}