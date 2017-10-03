using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
	float time; 
	int theScore; 
	bool theMessage; 
	int bronzeOre; 
	int silverOre; 
	int miningTime; 
	public int bronzeSupply;
	public int silverSupply;
	bool done1;  
	int miningTimeAdded;
	public GameObject bronze;
	int silverPlayer;
	public GameObject cubePrefab;
	Vector3 cubePosition;
	GameObject currentCube;
	float xPosition; 
	float zPosition;
	// Use this for initialization
	void Start () {
		bronzeOre = 0; 
		silverOre = 0; 
		miningTime = 2;
		bronzeSupply = 3; 
		silverSupply = 3;
		done1 = false;
		miningTimeAdded = 2;
		xPosition = Random.Range(1,7);
		zPosition = Random.Range(1,7); 

		cubePosition = new Vector3 (xPosition, 0, zPosition) ;
		currentCube = Instantiate (cubePrefab, cubePosition, Quaternion.identity);  
		currentCube.GetComponent<Renderer> ().material.color = Color.red;

	}

	
	// Update is called once per frame
	void Update () {
		if (Time.time <= miningTime) {
			
			if (bronzeOre < 3) {
				bronzeOre += 1 ; 
				print ("bronzeOre =" + bronzeOre); 
				bronzeSupply -= 1;

			} 

			if (silverOre < 3 && bronzeSupply == 0) {
				silverOre += 1; 
				print ("silverOre =" + silverOre); 
				silverSupply -= 1; 
			}
			miningTime += miningTimeAdded;
		}
	}				 
}
