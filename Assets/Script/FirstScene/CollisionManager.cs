using UnityEngine;
using System.Collections;

public class CollisionManager : MonoBehaviour {

	public FistCubeStandOn fistcubestandon;
	public GameManager gamemanager;
	public CubeControll cubecontroll;
	public GameComplete gamecomplete;
	void Start () {
//		cubecontroll = GetComponent<CubeControll> ();
		cubecontroll.collisionmanager = this;
		gamecomplete.collisionmanager = this;
		fistcubestandon.collisionmanager = this;
	}
	

	void Update () {
	
	}
}
