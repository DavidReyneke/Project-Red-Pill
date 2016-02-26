using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent (typeof(AudioSource))]

public class VREnvironment : MonoBehaviour {

	public MovieTexture movTexture;

	private bool movieStarts = false;

	// Use this for initialization
	void Start () {
		movTexture.loop = true;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void playMovie() {
		if (!movieStarts) {
			movieStarts = true;	
			GetComponent<Renderer> ().material.mainTexture = movTexture;
			movTexture.Play ();
		}
	}
		
}
