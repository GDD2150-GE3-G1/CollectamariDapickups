using UnityEngine;
using System.Collections;

public class InstructionBackScript : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Application.LoadLevel ("StartMenu");
		}
	}
}
