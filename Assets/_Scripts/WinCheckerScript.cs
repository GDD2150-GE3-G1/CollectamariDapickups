using UnityEngine;
using System.Collections;

public class WinCheckerScript : MonoBehaviour {
	
	// Update is called once per frame
	void LateUpdate () {
		if (transform.position.y < 0) {
			Application.Quit();
		} else if (CollisionController.collectedPickups > 300) {
			Application.Quit();
		}
	}
}
