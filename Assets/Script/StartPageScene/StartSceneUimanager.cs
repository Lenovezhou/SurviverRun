using UnityEngine;
using System.Collections;


public enum SelectScenes
{
	First,
	Second,
	Third
}

public class StartSceneUimanager : MonoBehaviour {

	public FirstSceneButton firstbutton;
	public SecondSceneButton secondbutton;
	public ThirdSceneButton thirdbutton;
	public TestUImanager testuimanager;
	void Start () {
		firstbutton.uimanager = this;
		secondbutton.uimanager = this;
		thirdbutton.uimanager = this;
	}


	public void SelectScene(SelectScenes selectscenes)
	{
		switch(selectscenes)
		{
		case SelectScenes.First:
			Application.LoadLevel ("Animator_test");
			break;
		case SelectScenes.Second:
			Application.LoadLevel ("Animator_test2");
			break;
		case SelectScenes.Third:
			Application.LoadLevel ("Animator_test3");
			break;
		}
//		gameObject.SetActive (false);

	}

	void Update () {
	
	}
}
