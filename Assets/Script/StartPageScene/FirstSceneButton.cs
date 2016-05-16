using UnityEngine;
using System.Collections;

public class FirstSceneButton : MonoBehaviour {

	public StartSceneUimanager uimanager;

	void Start () {
	
	}
	public void FistScene()
	{
		uimanager.SelectScene (SelectScenes.First);
	}

	void Update () {
	
	}
}
