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
		uimanager.gamemanager.ReStartGame();
		AudioManager.GetInstance ().PlayMusic (1);
		AudioManager.GetInstance ().PlayBackground ();
	}

	public void BackHome()
	{
		Application.LoadLevel ("SurviverRunStartPage");
//		uimanager.gamemanager.StartGame();
		AudioManager.GetInstance ().PlayMusic (6);
		}

	void Update () {
	
	}
}
