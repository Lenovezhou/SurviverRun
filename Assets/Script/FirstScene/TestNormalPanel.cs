using UnityEngine;
using System.Collections;

public class TestNormalPanel : MonoBehaviour {
	public GameManager gamemanager;
	public TestUImanager uimanager;
	void Start () {
	
	}
	public void PauseGame()
	{
		uimanager.OpenPanel (UITYPE.PausePanel);
		uimanager.gamemanager.PauseGame ();
	}

	void Update () {
	
	}
}
