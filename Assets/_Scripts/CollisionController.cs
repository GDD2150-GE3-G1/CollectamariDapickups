using UnityEngine;
using System.Collections;

public class CollisionController : MonoBehaviour {

	public static int collectedPickups = 0;

	void OnCollisionEnter(Collision collidedWith) {
		if (collidedWith.gameObject.tag == "Pickup") {
			collectedPickups++;
			Debug.Log(collectedPickups + " items have been picked up");

			BoxCollider b = collidedWith.collider as BoxCollider;
			Vector3 shrinkCollider = b.size;
			shrinkCollider = new Vector3(shrinkCollider.x / 10, shrinkCollider.y / 10, shrinkCollider.z / 10);
			b.size = shrinkCollider;

			rigidbody.mass += collidedWith.rigidbody.mass;

			Destroy (collidedWith.rigidbody);
			collidedWith.transform.parent = transform;
		}
	}
}
