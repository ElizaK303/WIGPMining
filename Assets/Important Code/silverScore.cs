using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class silverScore : MonoBehaviour {
	NewBehaviourScript newBehaviorScript;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnMouseUp() {
		NewBehaviourScript.score += 100;
		gameObject.SetActive (false);
		NewBehaviourScript.silverSupply += 1;  

	}
}
