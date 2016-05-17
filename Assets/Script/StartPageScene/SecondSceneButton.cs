using UnityEngine;
using System.Collections;

public class SecondSceneButton : MonoBehaviour {

	public SelectLevelPanel selectlevelpanel;
	void Start () {
	
	}
	
	public void SecondScene()
	{
		selectlevelpanel.startsceneuimanager.SelectScene(SelectScenes.First);
	}

	void Update () {
	
	}
}
