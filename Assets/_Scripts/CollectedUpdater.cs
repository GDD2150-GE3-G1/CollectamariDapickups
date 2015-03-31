using UnityEngine;
using System.Collections;

public class CollectedUpdater : MonoBehaviour {
	
	// Update is called once per frame
	void LateUpdate () {
		this.guiText.text = "Collected: " + CollisionController.collectedPickups;
	}
}
