using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
	public static int score; 
	public static int oldScore;
	float time; 
	bool theMessage; 
	int bronzeOre; 
	int silverOre; 
	int miningTime; 
	public static int bronzeSupply;
	public static int silverSupply; 
	int miningTimeAdded;
	public GameObject bronzePrefab; 
	public GameObject bronze;
	int silverPlayer;
	public GameObject silver;
	Vector3 cubePosition;
	float xPosition; 
	public int goldScore;
	public GameObject gold;
	Vector3 cubePosition1; 
	int max = bronzeSupply + silverSupply + 1;
	public GameObject silverPrefab;
	public GameObject goldPrefab;
	int goldOre;
	public Text printScore;

	// Use this for initialization
	void Start () {
		bronzeOre = 0; 
		silverOre = 0; 
		miningTime = 4;
		bronzeSupply = 4; 
		silverSupply = 4;
		miningTimeAdded = 2;
		xPosition = 0; 
		score = 0;
		cubePosition = new Vector3 (xPosition, 0, 0) ;
		cubePosition1 = new Vector3 (0, 100, 100);
		bronze = Instantiate (bronzePrefab, cubePosition1, Quaternion.identity);  
		bronze.GetComponent <Renderer> ().material.color = Color.red;
		silver = Instantiate (silverPrefab, cubePosition1, Quaternion.identity);  
		silver.GetComponent <Renderer> ().material.color = Color.gray;
		goldScore = 0;
		gold = Instantiate (goldPrefab, cubePosition1, Quaternion.identity);  
		gold.GetComponent <Renderer> ().material.color = Color.yellow;
		goldOre = 0;
		PrintScore ();
	}

	// Update is called once per frame
	void Update () {
		PrintScore ();
		if (Time.time >= miningTime) {
			for (int i = 0; i < max; i += 10) {
				Collider[] intersecting = Physics.OverlapSphere (new Vector3 (i, 0, 0), 0.01f);
				if (intersecting.Length == 0) {
					xPosition = i;
				}
			}
			if (xPosition < 80) {
				if (bronzeSupply != 0) {
					bronzeOre += 1; 
					print ("bronzeOre =" + bronzeOre); 
					bronzeSupply -= 1;
					cubePosition = new Vector3 (xPosition += 10, 0, 0);
					Instantiate (bronze, cubePosition, Quaternion.identity);
					bronze.GetComponent <Renderer> ().material.color = Color.red; 
					}
				} 

				if (silverSupply != 0 && bronzeSupply == 0) {
					silverOre += 1; 
					print ("silverOre =" + silverOre); 
					cubePosition = new Vector3 (xPosition += 10, 0, 0);
					silverSupply -= 1; 
					Instantiate (silver, cubePosition, Quaternion.identity);
					silver.GetComponent <Renderer> ().material.color = Color.grey; 
				}
				if (silverSupply == 2 && bronzeSupply == 2) {
					gold = Instantiate (goldPrefab, new Vector3 (30, 0, 10), Quaternion.identity);  
					gold.GetComponent <Renderer> ().material.color = Color.yellow;
					goldOre += 1; 
					print ("You found a gold! Gold ore = " + goldOre);
				}
				miningTime += miningTimeAdded;
			}
		}
	void PrintScore() {
		printScore.text = "Your score from your last round = " + score.ToString ();
	}
}
