using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreLogic : MonoBehaviour {
	public int score = 0;
	Text txt;

	// Use this for initialization
	void Start () {
		txt = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		printScore ();
	}

	public void addToScoreVOID(){
		score= score + 1;
	}

	public void printScore(){
		txt.text = "Score: " + score;
	}
}
