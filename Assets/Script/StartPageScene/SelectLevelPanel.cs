using UnityEngine;
using System.Collections;

public class SelectLevelPanel : MonoBehaviour {

	public StartSceneUimanager startsceneuimanager;
	void Start () {
		}

	public void FistScene()
	{
		startsceneuimanager.SelectScene(SelectScenes.First);
		startsceneuimanager.audiomanager.PlayMusic ();
		//		}
	}
	public void SecondScene()
	{
		startsceneuimanager.SelectScene(SelectScenes.Second);
		startsceneuimanager.audiomanager.PlayMusic ();
		//		}
	}
	public void ThirdScene()
	{
		startsceneuimanager.SelectScene(SelectScenes.First);
		startsceneuimanager.audiomanager.PlayMusic ();
		//		}
	}
	public void BackHome()
	{
		startsceneuimanager.StartPanelControll (StartPanelState.logopanel);
		startsceneuimanager.audiomanager.PlayMusic ();
		//		}
	}

	void Update () {
	
	}
}
