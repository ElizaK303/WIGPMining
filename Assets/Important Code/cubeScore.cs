using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeScore : MonoBehaviour {
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update (){ 

	}
	void OnMouseUp() {
		NewBehaviourScript.score += 1;
		gameObject.SetActive (false);
		NewBehaviourScript.bronzeSupply += 1;  
	}
}
