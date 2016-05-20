using UnityEngine;
using System.Collections;

public class LogoPanel : MonoBehaviour {


	public AudioClip audioclip;
	public StartSceneUimanager startsceneuimanager;
	void Start () {

	}
	public void StartGame()
	{
	startsceneuimanager.StartPanelControll (StartPanelState.selectpanel);
//		if(startsceneuimanager.audiomanager!=null) {
			startsceneuimanager.audiomanager.PlayMusic ();
//		}

	}

	void Update () {
	
	}
}
