using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TestNormalPanel : MonoBehaviour {
	public GameManager gamemanager;
	public TestUImanager uimanager;
	public int score;
	public float timer;
	public Text scoretext, timetext;
	void Start () {
	
	}
	public void PauseGame()
	{
		uimanager.OpenPanel (UITYPE.PausePanel);
		uimanager.gamemanager.PauseGame ();

	}
//	//	加分
//	public void AddScore(int newvalue){
//		score+=newvalue;
//
//
//
//	}
	//	重置分数和时间
	public void ResetST()
	{
		score = 0;
		timer = 0f;
	}
//	//	时间
//	public void Addtime()
//	{
//		timer += Time.time;
//
//	}

	void Update () {
		scoretext.text = "Score:" + score;
		timetext.text = "Time:"+timer;
	}
}
