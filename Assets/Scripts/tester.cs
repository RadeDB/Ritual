using UnityEngine;
using System.Collections;

public class tester : MonoBehaviour {

	ScoreManager scoreman;

	// Use this for initialization
	void Start () {
	
		scoreman = GameObject.FindGameObjectWithTag ("test").GetComponent<ScoreManager>();

		scoreman.hitProgress ("bad");
		scoreman.hitProgress ("perfect");
		scoreman.hitProgress ("ok");
		scoreman.hitProgress ("missed");

	}
	
	// Update is called once per frame
	void Update () {


	
	}

	//  B   p    o   m
//	s = 1 + 10 + 5 + -5 === 11
//	h = 0 + 2  + 1 + -2 === 1
//	n = 0 + 1  + 1 = 0  === 0


}
