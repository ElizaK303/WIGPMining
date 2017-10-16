using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeScore : MonoBehaviour {
	private NewBehaviourScript newBehaviorScript;

	// Use this for initialization
	void Start () {
		newBehaviorScript = GetComponent<NewBehaviourScript> ();
	}
	
	// Update is called once per frame
	void Update (){ 

	}
	void OnMouseUp() {
		if (newBehaviorScript.cubePrefab.GetComponent <Renderer> ().material.color == Color.red) {
			NewBehaviourScript.score += 1;
			gameObject.SetActive (false);
			NewBehaviourScript.bronzeSupply += 1;  
		}
	}
}
