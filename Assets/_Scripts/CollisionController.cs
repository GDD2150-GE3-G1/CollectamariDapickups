using UnityEngine;
using System.Collections;

public class CollisionController : MonoBehaviour {

	void OnCollisionEnter(Collision info) {
		if (info.gameObject.tag == "Pickup") {
			rigidbody.mass += info.rigidbody.mass;

			SphereCollider s = collider as SphereCollider;
			s.radius += 0.02F;

			Destroy (info.rigidbody);
			info.transform.parent = transform;
		}
	}
}
