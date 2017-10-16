using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goldScore : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnMouseUp() {
		NewBehaviourScript.score += 100;
		gameObject.SetActive (false);
	}
}
