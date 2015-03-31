using UnityEngine;
using System.Collections;

public class CollisionController : MonoBehaviour {

	void OnCollisionEnter(Collision collidedWith) {
		if (collidedWith.gameObject.tag == "Pickup") {
			BoxCollider b = collidedWith.collider as BoxCollider;
			Vector3 shrinkCollider = b.size;
			shrinkCollider = new Vector3(shrinkCollider.x / 10, shrinkCollider.y / 10, shrinkCollider.z / 10);
			b.size = shrinkCollider;

			rigidbody.mass += collidedWith.rigidbody.mass;

			SphereCollider s = collider as SphereCollider;
			s.radius += 0.0025F;

			Destroy (collidedWith.rigidbody);
			collidedWith.transform.parent = transform;
		}
	}
}
