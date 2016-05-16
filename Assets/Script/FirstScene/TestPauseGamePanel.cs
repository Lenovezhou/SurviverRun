using UnityEngine;
using System.Collections;

public class TestPauseGamePanel : MonoBehaviour {
//	public StartSceneUimanager startsceneuimanager;
	public TestUImanager uimanager;
	void Start () {
//		startsceneuimanager.testuimanager = this;
	}
	public void RetrunGame()
	{
		uimanager.OpenPanel (UITYPE.NormalPanel);
		uimanager.gamemanager.StartGame ();
		
	}
	public void BackHome()
	{
		uimanager.OpenPanel (UITYPE.HomePanel);
		uimanager.gamemanager.HomePage ();
	}

	void Update () {
	
	}
}
