using UnityEngine;
using System.Collections;

public class EventHandler : MonoBehaviour {

	public static EventHandler handler = null;  

	public VREnvironment environment; 

	//Awake is always called before any Start functions
	void Awake()
	{
		//Check if instance already exists
		if (handler == null)

			//if not, set instance to this
			handler = this;

		//If instance already exists and it's not this:
		else if (handler != this)

			//Then destroy this. This enforces our singleton pattern, meaning there can only ever be one instance of a GameManager.
			Destroy(gameObject);    

		//Sets this to not be destroyed when reloading scene
		DontDestroyOnLoad(gameObject);
	}

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
	
	}

	public void triggerMovie() {
		environment.playMovie ();
	}
}
