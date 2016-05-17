using UnityEngine;
using System.Collections;

public class FirstSceneButton : MonoBehaviour {


	public SelectLevelPanel selectlevelpanel;
	void Start () {
	
	}
	public void FistScene()
	{
		selectlevelpanel.startsceneuimanager.SelectScene(SelectScenes.First);
	
	}

	void Update () {
	
	}
}
