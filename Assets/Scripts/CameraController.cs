using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {
	public GameObject player;
	private Vector3 offset;

	// Use this for initialization
	void Start () {
		offset = transform.position - player.transform.position;
	}
	
	// Update is called once per frame, gauranteed to run after all items have been processed & updated
	void LateUpdate () { //As player is moved with keyboard, the camera is moved to be aligned with the player object
		transform.position = player.transform.position + offset;
	}
}
