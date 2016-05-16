using UnityEngine;
using System.Collections;

public class ThirdSceneButton : MonoBehaviour {

	public StartSceneUimanager uimanager;
	void Start () {
	
	}
	

	public void ThirdScene()
	{
		uimanager.SelectScene (SelectScenes.First);
	}

	void Update () {
	
	}
}
