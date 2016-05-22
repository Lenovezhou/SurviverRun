using UnityEngine;
using System.Collections;

public class FistCubeStandOn : MonoBehaviour {

	public CollisionManager collisionmanager;
	public MeshRenderer mesh;
	void Start () {
		
	}
	
	 
	void OnCollisionStay()
	{
		if (collisionmanager.gamemanager.playermanager.mariochangecolor.mc!=mariocolor.red)
		{
			collisionmanager.gamemanager.Dead (); 
		} 
	}

	void Update () {
	
	}
}
