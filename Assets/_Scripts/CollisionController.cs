using UnityEngine;
using System.Collections;

public class CollisionController : MonoBehaviour {

	void OnCollisionEnter(Collision other) {
		gameObject.AddComponent<FixedJoint> ();
		gameObject.GetComponent<FixedJoint> ().connectedBody = other.rigidbody;
		gameObject.rigidbody.isKinematic = false;
		gameObject.collider.enabled = false;
		gameObject.tag = "Player";
	}
}
