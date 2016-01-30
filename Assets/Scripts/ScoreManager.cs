using UnityEngine;
using System.Collections;

public class ScoreManager : MonoBehaviour {

	private int score = 0;
	private int health = 0;
	private int noteStreak = 0;

//	string PERFECT = "perfect";
//	string OK = "ok";
//	string BAD = "bad";
//	string MISSED = "missed";

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public int getScore(){

		return score;
	}

	public int getHealth(){

		return health;

	}

	public int getNoteStreak (){
		return noteStreak;

	}
		
	public void hitProgress (string hitType){

		switch(hitType){

		case "perfect":
		case "ok":
			
			goodHit(hitType);
			Debug.Log(" goodHit method :::: \n" + score + "\n" + health + "\n" + noteStreak + "\n");

			break;

		case "bad": 
		case "missed":
			
			badHit(hitType);
			Debug.Log(" badHit method :::: \n" + score + "\n" + health + "\n" + noteStreak + "\n");

			break;

		default:
			
			Debug.Log ("Problems passing the hitType");

			break;

		}

		Debug.Log("\n" + score + "\n" + health + "\n" + noteStreak + "\n");
	
	}

	public void goodHit(string hitType){

		if (hitType.Equals ("perfect")) {

			score += 10;
			health += 2;

		} else {
			
			score += 5;
			health++;

		}

		noteStreak++;

	}

	public void badHit(string hitType ) {

		if (hitType.Equals("bad")) {

			score++;

		} else {


			if (score != 0 || score >= 5 ) score -= 5;

			if (health != 0 || health >= 2 ) health -= 2;

		}

		noteStreak = 0;
	
	}

}
