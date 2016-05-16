using UnityEngine;
using System.Collections;

public class SecondSceneButton : MonoBehaviour {

	public StartSceneUimanager uimanager;
	void Start () {
	
	}
	
	public void SecondScene()
	{
		uimanager.SelectScene (SelectScenes.First);
	}

	void Update () {
	
	}
}
