using UnityEngine;
using System.Collections;

public class InstructionButtonScript : MonoBehaviour {

	void OnMouseDown () {
		if (Input.GetMouseButtonDown (0)) {
			Application.LoadLevel("Instructions");
		}
	}
}
