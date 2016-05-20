using UnityEngine;
using System.Collections;

public class GameComplete : MonoBehaviour {

	public CollisionManager collisionmanager;
//	public GameManager gamemanager;
	void Start () {
		
	}
	
	public void OnTriggerEnter(Collider other)
	{
//		Destroy (gameObject,0.5f);
		collisionmanager.gamemanager.PauseGame ();
		collisionmanager.gamemanager.CompleteGame ();
	}
	void Update () {
	
	}
}
