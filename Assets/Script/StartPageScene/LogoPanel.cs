using UnityEngine;
using System.Collections;

public class LogoPanel : MonoBehaviour {

	public StartSceneUimanager startsceneuimanager;
	void Start () {

	}
	public void StartGame()
	{
	startsceneuimanager.StartPanelControll (StartPanelState.selectpanel);
	}

	void Update () {
	
	}
}
