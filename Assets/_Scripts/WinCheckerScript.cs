﻿using UnityEngine;
using System.Collections;

public class WinCheckerScript : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y < 0 || CollisionController.collectedPickups > 500) {
			Application.LoadLevel("Winner");
			CollisionController.collectedPickups = 0;
			TimerUpdater.remainingSeconds = 120;
		}
		else if (TimerUpdater.remainingSeconds < 0) {
			Application.LoadLevel("Loser");
			CollisionController.collectedPickups = 0;
			TimerUpdater.remainingSeconds = 120;
		}
	}
}
