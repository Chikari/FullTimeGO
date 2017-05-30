using UnityEngine;
using System.Collections;

public class PlayerCollider : MonoBehaviour {

	private Player parentPlayer;

	// Use this for initialization
	void Start () {
		parentPlayer = this.transform.parent.gameObject.GetComponent<Player>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnMouseDown(){
		Debug.Log("PlayerCollider onClick triggered");
		parentPlayer.moveForward();
	}
}
