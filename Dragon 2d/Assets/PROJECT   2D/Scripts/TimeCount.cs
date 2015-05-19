using UnityEngine;
using System.Collections;

public class TimeCount : MonoBehaviour {

	public float timeRemainig = 17;
	public int a = 100;
	public int b = 100;
	public int c = 200;
	public int d = 100;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		timeRemainig -= Time.deltaTime;
	}

	void OnGUI ()
	{
		if (timeRemainig >0) 
		{
			GUI.Label(new Rect(a,b,c,d), "Time Remaining : " + (int)timeRemainig);
		}

		else if (timeRemainig < 0) 
		{
			Application.LoadLevel ("secret");
		}
	}
}
