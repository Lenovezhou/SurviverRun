using UnityEngine;
using System.Collections;
using DG.Tweening;



public class SelectLevelPanel : MonoBehaviour {
	public DOTweenVisualManager dotweenmanager;
	public DOTweenAnimation dotweenanimation;
	public StartSceneUimanager startsceneuimanager;
	void Start () {
		GameObject content = gameObject.FindInChildren ("Content");
		dotweenmanager = content.GetComponent<DOTweenVisualManager> ();
		dotweenanimation = content.GetComponent<DOTweenAnimation> ();
	}
	//		选择哪个panel下降
	public void SelectLevelPanleDown()
	{
//		dotweenanimation.DOPlayBackwards ();
		dotweenanimation.DORestartById ("down");
	}

	public void SelectLevelpanleUp()
	{
		dotweenanimation.DORestartById ("up");
		AudioManager.GetInstance ().PlayMusic (4);
	}


	//		Dotween的方法
	public void OnComplete()
	{
//		dotweenanimation.onComplete.RemoveListener (OnComplete);
		startsceneuimanager.SelectPanelChoose (startsceneuimanager.logopanel.gameObject ,gameObject);

	}


	//		第一关
	public void FistScene()
	{
		startsceneuimanager.SelectScene(SelectScenes.First);
		AudioManager.GetInstance ().PlayMusic (3);
	}
	//		第二关
	public void SecondScene()
	{
		startsceneuimanager.SelectScene(SelectScenes.Second);
		AudioManager.GetInstance ().PlayMusic (3);
	}
	//		第三关
	public void ThirdScene()
	{
		startsceneuimanager.SelectScene(SelectScenes.First);
		AudioManager.GetInstance ().PlayMusic (3);
	}
	//		返回
	public void BackHome()
	{
		
//		dotweenanimation.onComplete.AddListener (OnComplete);
		startsceneuimanager.StartPanelControll (StartPanelState.logopanel);
		AudioManager.GetInstance ().PlayMusic (6);
	}

	void Update () {
	
	}
}
