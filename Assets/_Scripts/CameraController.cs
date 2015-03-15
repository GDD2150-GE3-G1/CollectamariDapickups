using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public GameObject player;
	private Vector3 cameraOffset;

	void Start () {
		cameraOffset = transform.position;
	}

	void LateUpdate () {
		transform.position = player.transform.position + cameraOffset;
	}
}
