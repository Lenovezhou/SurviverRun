using UnityEngine;
using System.Collections;

public class PanelFirstBackButton : MonoBehaviour {

	public SelectLevelPanel selectlevelpanel;
	void Start () {
	
	}
	public void BackHome()
	{
		selectlevelpanel.startsceneuimanager.StartPanelControll (StartPanelState.logopanel);
	}

	void Update () {
	
	}
}
