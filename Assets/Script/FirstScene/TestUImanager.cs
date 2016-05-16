using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public enum UITYPE
{
	HomePanel,
	NormalPanel,
	PausePanel
}

public class TestUImanager : MonoBehaviour {

	public GameManager gamemanager;
	public TestHomePanel hometest1;
	public TestNormalPanel normaltest2;
	public TestPauseGamePanel pausetest3;

	GameObject oldpanel;
	void Start () {
		hometest1.uimanager = this;
		normaltest2.uimanager = this;
		pausetest3.uimanager = this;
		OpenPanelObj (hometest1.gameObject);
	}
	//	枚举值的应用来使对象调用时可以简化操作且不用又要引用其变量；
	public void OpenPanel(UITYPE type)
	{
		switch (type) 
		{
		case UITYPE.HomePanel:
			OpenPanelObj (hometest1.gameObject);
			Application.LoadLevel ("SurviverRunStartPage");
			break;
		case UITYPE.NormalPanel:
			OpenPanelObj (normaltest2.gameObject);
			break;
		case UITYPE.PausePanel:
			OpenPanelObj (pausetest3.gameObject);
			break;

		}

	}

	private void OpenPanelObj(GameObject obj )
	{
		if (obj!=null) {
			if (oldpanel!=null) {
				oldpanel.SetActive (false);
			}

			obj.SetActive (true);
			oldpanel = obj;
		}

	}

	void Update () {
	
	}
}
