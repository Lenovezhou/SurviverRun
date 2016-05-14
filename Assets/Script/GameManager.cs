using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public enum pausestate{
	pause,
	unpause
}
public class GameManager : MonoBehaviour {
	
	public Text ScoreText;
	public Animator GameOveranim;
//	public mariomovement mariomove;
	public marioChangeColor mmcc;
	public Rigidbody mariorbin;
	public mariomovement playerMove;
	public Vector3 mariomaxvelocity;
	Vector3 currentvelocity;
	public pausestate state=pausestate.unpause;
	bool isDead;
	public string A;
	int Score;

	void Start () {
		HomePage ();
		currentvelocity = mariorbin.velocity;
	}
	//	主页
	public void HomePage(){
//		PauseGame ();
		Restartgame();
		mariorbin.isKinematic = true;
		SetAnimator("Wait");
		state = pausestate.pause;
	} 
	
	public void Restartgame()
	{
		//	依然会有力
		playerMove.Reset();	//	位置为原点
//		PauseGame ();		//	调用暂停		
		playerMove.pj=playerjump.run;
//		mariorbin.transform.position = Vector3.zero;
	}
	//	暂停游戏
	public void PauseGame()
	{
		if (state == pausestate.unpause&&!isDead) 
		{
			mariorbin.isKinematic = true;
			SetAnimator ("Pause");
			state = pausestate.pause;
		}
		else if(state == pausestate.pause)
		{

			mariorbin.isKinematic = false;
			SetAnimator ("Start");
			state = pausestate.unpause;

		}
	}

	//	专门为暂停



	//	动画控制
	void SetAnimator(string name){
		GameOveranim.SetBool (A,false);
		GameOveranim.SetBool (name,true);
		A = name;
	}


	//	加分
	public void AddScore(int newvalue){
		Score+=newvalue;
		ScoreText.text = "Score:" + Score;
	}

	//	游戏结束
	public void Dead(){
//		return;
		isDead = true;
//		GameOveranim.SetTrigger ("GameOver");
		Restartgame ();

	}


	void Update () {
		
		//	限制速度
		if (mariorbin.velocity.z > mariomaxvelocity.z) {
			playerMove.ForRun = false;
		} else {
			playerMove.ForRun = true;
		}
			
		 }






}
