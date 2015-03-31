using UnityEngine;
using System.Collections;

public class WinCheckerScript : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y < 0 || CollisionController.collectedPickups > 500) {
			Application.LoadLevel("Winner");
		}
		else if (TimerUpdater.remainingSeconds < 0) {

		}
	}
}
