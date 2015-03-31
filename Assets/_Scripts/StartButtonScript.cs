using UnityEngine;
using System.Collections;

public class StartButtonScript : MonoBehaviour {

	void OnMouseDown () {
		if (Input.GetMouseButtonDown (0)) {
			Application.LoadLevel("Main");
		}
	}
}
