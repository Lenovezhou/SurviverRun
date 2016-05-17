using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public enum pausestate{
	pause,
	unpause
}
public class GameManager : MonoBehaviour {
	public StartSceneUimanager startsceneuimanager;
	public CubeControll cubemanager;
	public TestUImanager uimanager;
	public Text ScoreText;
	public Animator GameOveranim;
//	public mariomovement mariomove;
	public marioChangeColor mmcc;
	public Rigidbody mariorbin;
	public mariomovement playerMove;
	public Vector3 mariomaxvelocity;
	Vector3 currentvelocity;
	public pausestate state=pausestate.pause;
	bool isDead;
	public string A;
	int Score;

	void Start () {
		mariorbin.isKinematic = false;
		ScoreText.text = "Score:0";
		HomePage ();
		currentvelocity = mariorbin.velocity;
		uimanager.gamemanager = this;
		startsceneuimanager = GetComponent<StartSceneUimanager> ();
	}
	//	主页
	public void HomePage(){
		Restartgame ();
//		SetAnimator("Wait");
	} 
	
	public void Restartgame()
	{
		//	依然会有力
		playerMove.Reset();
		playerMove.MarioAnimator (playerjump.run);
//		mariorbin.transform.position = Vector3.zero;
	}
	//	暂停游戏
	public void PauseGame()
	{
		if (state == pausestate.unpause&&!isDead) 
		{
			mariorbin.isKinematic = true;
//			SetAnimator ("Pause");
			state = pausestate.pause;
		}

	}

	//	动画控制
//	void SetAnimator(string name){
//		GameOveranim.SetBool (A,false);
//		GameOveranim.SetBool (name,true);
//		A = name;
//	}
	//	首次开始游戏
	public void StartGame()
	{
		Restartgame ();
		playerMove.pj = playerjump.run;
		mariorbin.isKinematic = false;
//		SetAnimator ("Start");
		state = pausestate.unpause;
	}


	//	加分
	public void AddScore(int newvalue){
		Score+=newvalue;
		ScoreText.text = "Score:" + Score;
	}

	//	游戏结束
	public void Dead(){
		
		isDead = true;
		StartGame ();
//		playerMove.enabled = false;
//		mmcc.enabled = false;
//		playerMove.SetForRun (false); 
	}


	void Update () {
		
		//	限制速度

		playerMove.SetForRun(mariorbin.velocity.z<mariomaxvelocity.z);

//		if (mariorbin.velocity.z > mariomaxvelocity.z) {
//			playerMove.SetForRun (false);
//		} else {
//			playerMove.SetForRun (true);
//		}
			
		 }






}
