using UnityEngine;
using System.Collections;

public class GazeObject : MonoBehaviour {

	double gazeAtCount = 0;

	bool gazing = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (gazing) {
			print (gazeAtCount);
			gazeAtCount++;
		}

		if (gazeAtCount > 100) {
			GetComponent<BoxCollider> ().enabled = false;
			gazeAway ();
			EventHandler.handler.triggerMovie ();
		}
	}

	public void gazeAt() {
		gazing = true;
	}

	public void gazeAway() {
		gazing = false;
		gazeAtCount = 0;
	}
}
