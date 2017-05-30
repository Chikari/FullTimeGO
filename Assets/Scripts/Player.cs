using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public float forwardDistance = 10f;
	public float forwardSpeed = 1.0f;

	private bool movingForward = false;
	private float distanceTraveled;
	private Vector3 oldPosition;
	// Use this for initialization
	void Start () {
		movingForward = false;
		distanceTraveled = 0f;
	}
	
	// Update is called once per frame
	void Update () {
		if (movingForward){
			transform.Translate(Vector3.forward * forwardSpeed * Time.deltaTime);
			distanceTraveled = Vector3.Distance(oldPosition, transform.position);
			if (distanceTraveled >= forwardDistance){
				movingForward = false;
			}
		}
	}
	
	public void moveForward(){
		Debug.Log("player moving forward...");
		movingForward = true;
		oldPosition = transform.position;
		distanceTraveled = 0f;
	}
}
