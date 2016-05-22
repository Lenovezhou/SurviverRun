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

	public AudioManager audiomanager;
	public GameObject sceneuigameobject;
	public LogoPanel logopanel;
	public SelectLevelPanel selectlevelpanel;
	public TestUImanager testuimanager;
	StartPanelState startpanelstate;
	void Start () {

		logopanel.startsceneuimanager = this;
		selectlevelpanel.startsceneuimanager = this;

	}


	public void SelectScene(SelectScenes selectscenes)
	{
		switch(selectscenes )
		{
		case SelectScenes.First:
			Application.LoadLevel ("Animator_test");
			break;
		case SelectScenes.Second:
			Application.LoadLevel ("Animator_test01");
			break;
		case SelectScenes.Third:
			Application.LoadLevel ("Animator_test3");
			break;
		}


	}
	public void StartPanelControll(StartPanelState startpanelstate)
	{
		
		switch(startpanelstate)
		{

		case StartPanelState.logopanel:
			selectlevelpanel.SelectLevelPanleDown ();
//			
			break;
		case StartPanelState.selectpanel:
			logopanel.LogoPanleDown ();
			break;
		}

	}
	public void SelectPanelChoose(GameObject openobj,GameObject closeobj)
	{
		openobj.SetActive (true);
		closeobj.SetActive (false);
		if (openobj.name=="ENTERGamePanel") 
		{
			logopanel.LogoPanleUP ();
		}
		selectlevelpanel.SelectLevelpanleUp ();
			
	}

//	public void SelectPanelChoose()
//	{
//		startpanelstate = startpanelstate == StartPanelState.logopanel ? StartPanelState.selectpanel : StartPanelState.logopanel;
//	}


	void Update () {
	
	}
}
