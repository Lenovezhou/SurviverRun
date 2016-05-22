using UnityEngine;
using System.Collections;
using DG.Tweening;


public class LogoPanel : MonoBehaviour {

	public AudioManager audiomanager;
	public AudioClip audioclip;
	public StartSceneUimanager startsceneuimanager;
	public DOTweenAnimation dotweenanimation;
	void Start () {
		dotweenanimation = GetComponent<DOTweenAnimation> ();
	}
	public void StartGame()
	{
		startsceneuimanager.StartPanelControll (StartPanelState.selectpanel);
		audiomanager = AudioManager.GetInstance ();
		audiomanager.PlayMusic (4);
		 }

	public void LogoPanleDown()
	{
		//		委托

		dotweenanimation.DORestartById ("down");
		//dotweenanimation.onComplete.AddListener( OnComplete1);
	}

	public void LogoPanleUP()
	{
		dotweenanimation.DORestartById("up");

	}

		
	//		dotween使用
	public void OnComplete1()
	{
		startsceneuimanager.SelectPanelChoose (startsceneuimanager.selectlevelpanel.gameObject ,gameObject);
	}
	void Update () {
	
	}
}
