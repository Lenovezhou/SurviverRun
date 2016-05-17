using UnityEngine;
using System.Collections;

public class SelectLevelPanel : MonoBehaviour {

	public StartSceneUimanager startsceneuimanager;

	public FirstSceneButton firstbutton;
	public SecondSceneButton secondbutton;
	public ThirdSceneButton thirdscenebutton;
	public PanelFirstBackButton panelfirstbackbutton;
	void Start () {
		firstbutton.selectlevelpanel = this;
		secondbutton.selectlevelpanel = this;
		thirdscenebutton.selectlevelpanel = this;
		panelfirstbackbutton.selectlevelpanel = this;
	}
	

	void Update () {
	
	}
}
