using UnityEngine;
using System.Collections;

public class PlayerManager : MonoBehaviour {

	public GameManager gamemanager;
	public marioChangeColor mariochangecolor;
	public mariomovement mariomovement;
	public ParticelTest particeltest;
	void Start () {
		mariochangecolor.playermanager = this;
		mariomovement.playermanager = this;
//		particeltest.playermanager = this;

	}
	

	void Update () {
	
	}
}
