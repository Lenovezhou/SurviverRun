using UnityEngine;
using System.Collections;

public class PlayerManager : MonoBehaviour {

	public GameManager gamemanager;
	public marioChangeColor mariochangecolor;
	public mariomovement mariomovement;
	void Start () {
		mariochangecolor.playermanager = this;
		mariomovement.playermanager = this;
	}
	

	void Update () {
	
	}
}
