using UnityEngine;
using System.Collections;


public enum SelectScenes
{
	First,
	Second,
	Third
}
public enum StartPanelState
{
	logopanel,
	selectpanel
}

public class StartSceneUimanager : MonoBehaviour {

	public LogoPanel logopanel;
	public SelectLevelPanel selectlevelpanel;
	public TestUImanager testuimanager;
	StartPanelState startpanelstate;
	void Start () {

		logopanel.startsceneuimanager = this;
		selectlevelpanel.startsceneuimanager = this;

		if (Global.startPanelState == StartPanelState.logopanel) {
			
		}
		else if(Global.startPanelState == StartPanelState.selectpanel)
		{
			
		}



	}


	public void SelectScene(SelectScenes selectscenes)
	{
		switch(selectscenes )
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


	}
	public void StartPanelControll(StartPanelState startpanelstate)
	{
//		SelectPanelChoose ();
		switch(startpanelstate)
		{
		case StartPanelState.logopanel:
			logopanel.gameObject.SetActive (true);
			selectlevelpanel.gameObject.SetActive (false);
			break;
		case StartPanelState.selectpanel:
			logopanel.gameObject.SetActive (false);
			selectlevelpanel.gameObject.SetActive (true);
			break;
		}

	}

//	public void SelectPanelChoose()
//	{
//		startpanelstate = startpanelstate == StartPanelState.logopanel ? StartPanelState.selectpanel : StartPanelState.logopanel;
//	}


	void Update () {
	
	}
}
