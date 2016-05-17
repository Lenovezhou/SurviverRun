using UnityEngine;
using System.Collections;

public class StartGameButton : MonoBehaviour {

	public LogoPanel logopanel;
	void Start () {
	
	}
	
	public void StartGame()
	{
		logopanel.startsceneuimanager.StartPanelControll (StartPanelState.selectpanel);
	}
	void Update () {
	
	}
}
