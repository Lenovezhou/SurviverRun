using UnityEngine;
using System.Collections;

public class GameComplete : MonoBehaviour {

	public GameCompletePanel gamecompletepanel;
	void Start () {
		
	}
	
	public void OnTriggerEnter(Collider other)
	{
		Destroy (gameObject,0.5f);
		gamecompletepanel.Complete ();

	}
	void Update () {
	
	}
}
