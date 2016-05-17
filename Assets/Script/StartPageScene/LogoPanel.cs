using UnityEngine;
using System.Collections;

public class LogoPanel : MonoBehaviour {

	public StartSceneUimanager startsceneuimanager;
	public StartGameButton startgamebutton;
	void Start () {
		startgamebutton.logopanel = this;
//		startgamebutton.logopanel = this;
	}
	

	void Update () {
	
	}
}
