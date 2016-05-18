using UnityEngine;
using System.Collections;

public class SelectLevelPanel : MonoBehaviour {

	public StartSceneUimanager startsceneuimanager;
	void Start () {
		}

	public void FistScene()
	{
		startsceneuimanager.SelectScene(SelectScenes.First);

	}
	public void SecondScene()
	{
		startsceneuimanager.SelectScene(SelectScenes.First);
	}
	public void ThirdScene()
	{
		startsceneuimanager.SelectScene(SelectScenes.First);
	}
	public void BackHome()
	{
		startsceneuimanager.StartPanelControll (StartPanelState.logopanel);
	}

	void Update () {
	
	}
}
