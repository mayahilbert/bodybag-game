using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DisplayMessage : MonoBehaviour {

	public int counter;
	//public Text message;

	// Use this for initialization
	void Start () {
		//message = GetComponent<Text> ();
	}

	// Update is called once per frame
	void Update () {
		Debug.Log (counter);

		if (counter == 13) {
			Debug.Log ("hey");
			SceneManager.LoadScene ("Glitch");
		}
	}


}
