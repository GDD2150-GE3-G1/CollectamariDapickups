using UnityEngine;
using System.Collections;

public class PickupSpawner : MonoBehaviour {

	public GameObject pickupObject;

	private float timeElapsed = 0F;
	private float spawnTime = 0.25F;


	void Update () {
		timeElapsed += Time.deltaTime;

		if (timeElapsed > spawnTime) {
			GameObject spawnedPickup = (GameObject)Instantiate(pickupObject);
			spawnedPickup.transform.position = new Vector3(Random.Range(-23, 23), 15, Random.Range(-23, 23));
			timeElapsed -= spawnTime;
		}
	}
}
