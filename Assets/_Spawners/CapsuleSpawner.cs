using UnityEngine;
using System.Collections;

public class CapsuleSpawner : MonoBehaviour {

	private float timeElapsed = 0F;
	private float spawnTime = 5F;

	void Update () {
		timeElapsed += Time.deltaTime;

		if (timeElapsed > spawnTime) {
			Debug.Log("Time passed");
			timeElapsed -= spawnTime;
		}
	}
}
