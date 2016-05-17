using UnityEngine;
using System.Collections;

public class ThirdSceneButton : MonoBehaviour {

	public SelectLevelPanel selectlevelpanel;
	void Start () {
	
	}
	

	public void ThirdScene()
	{
		selectlevelpanel.startsceneuimanager.SelectScene(SelectScenes.First);
	}

	void Update () {
	
	}
}
