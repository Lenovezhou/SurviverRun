using UnityEngine;
using System.Collections;

public class GameCompletePanel : MonoBehaviour {
	public  GameComplete gamecomplete;
	public TestUImanager testuimanager;
	void Start () {
		gamecomplete.gamecompletepanel = this;
	}
	
	public void Complete()
	{
		testuimanager.OpenPanel (UITYPE.gamecomplete);
	}
	void Update () {
	
	}
}
