using UnityEngine;
using System.Collections;

public class TimerUpdater : MonoBehaviour {

	public static int remainingSeconds = 120;
	private float elapsedTime;

	void Start() {
		elapsedTime = Time.deltaTime;
	}
	
	// Update is called once per frame
	void LateUpdate () {
		elapsedTime += Time.deltaTime;

		if (elapsedTime > 1) {
			int minutes = remainingSeconds / 60;
			int seconds = remainingSeconds % 60;
			this.guiText.text = string.Format ("{0:0}:{1:00}", minutes, seconds);
			remainingSeconds--;
			elapsedTime--;
		}
	}
}
