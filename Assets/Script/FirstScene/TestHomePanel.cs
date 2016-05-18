using UnityEngine;
using System.Collections;



public class TestHomePanel : MonoBehaviour {


	public TestUImanager uimanager;
	public void StartGame()
	{
		//	直接传入枚举值而最好不要又应用方法又应用他的变量；
		uimanager.OpenPanel (UITYPE.NormalPanel);
		uimanager.gamemanager.ContinueGame();
	}

	void Start () {
		
	}


	void Update () {
	
	}
}
