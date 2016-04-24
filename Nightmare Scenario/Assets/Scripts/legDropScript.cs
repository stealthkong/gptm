using UnityEngine;
using System.Collections;

public class legDropScript : MonoBehaviour {

	public Transform movingPlatform;
	public Transform legStart;
	public Transform legEnd;
	public Vector3 newPosition;
	public string currentState;
	public float smooth;
	public float resetTime;
	
	// Use this for initialization
	void Start () {
			dropLeg();	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		movingPlatform.position = Vector3.Lerp (movingPlatform.position, newPosition, smooth * Time.deltaTime);	
	}
	
	void dropLeg(){
		if (currentState == "Moving To legStart") {
			currentState = "Moving To legEnd";
			newPosition = legEnd.position;
		}
		else if (currentState == "") {
			currentState = "Moving To legEnd";
			newPosition = legEnd.position;
		}
		Invoke ("dropLeg", resetTime);
	}
}