using UnityEngine;
using System.Collections;

public class CollisionController : MonoBehaviour {

	void OnCollisionEnter(Collision info) {
		if (info.gameObject.tag == "Pickup") {
			Destroy (info.rigidbody);
			info.transform.parent = transform;
		}
	}
}
