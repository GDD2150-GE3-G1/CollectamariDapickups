using UnityEngine;
using System.Collections;

public class PickupSpawner : MonoBehaviour {

	public GameObject pickupObject;

	private float timeElapsed = 0F;
	private float spawnTime = 0.1F;


	void Update () {
		timeElapsed += Time.deltaTime;

		if (timeElapsed > spawnTime) {
			GameObject spawnedPickup = (GameObject)Instantiate(pickupObject);
			spawnedPickup.transform.position = new Vector3(Random.Range(-23, 23), 15, Random.Range(-23, 23));
			spawnedPickup.renderer.material.color = new Color(Random.value, Random.value, Random.value, 1f);
			timeElapsed -= spawnTime;
		}
	}
}
