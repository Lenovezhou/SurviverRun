using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public enum pausestate{
	pause,
	unpause
}
public class GameManager : MonoBehaviour {
	public AudioManager audiomanager;
	public CollisionManager collisionmanager;
	public StartSceneUimanager startsceneuimanager;
	public CubeControll cubemanager;
	public PlayerManager playermanager;
	public TestUImanager uimanager;
	public Vector3 mariomaxvelocity;
	Vector3 currentvelocity;
	public pausestate state=pausestate.pause;
	bool isDead;

	void Start () {

		playermanager.mariomovement.SetForIsKinematic (false);
		//		ScoreText.text = "Score:0";
		StartGame ();
		currentvelocity = playermanager.mariomovement.rigidbody.velocity;
		startsceneuimanager = GetComponent<StartSceneUimanager> ();
	}


	//	播放音乐
		
//		public void PlayMusic(AudioClip clip)
//		{
//		audiomanager.audiosource.Play ();
//		}


	//	暂停游戏
	public void PauseGame()
	{
		if (state == pausestate.unpause&&!isDead) 
		{
			playermanager.mariomovement.SetForIsKinematic (true);
//			SetAnimator ("Pause");
			state = pausestate.pause;
		}
	}
		
	//	首次开始游戏
	public void StartGame()
	{
		uimanager.normaltest2.ResetST ();						//	重置时间和分数
		playermanager.mariochangecolor.ResetColor ();
//		AddScore (0);
		isDead = false;
		playermanager.mariomovement.Reset();
		playermanager.mariomovement.pj = playerjump.run;
		playermanager.mariomovement.SetForIsKinematic (false);
//		SetAnimator ("Start");
		state = pausestate.unpause;
	}
	public void ContinueGame()
	{
		playermanager.mariomovement.SetForIsKinematic (false);
		state = pausestate.unpause;
	}



	//	游戏结束
	public void Dead(){
		isDead = true;
		StartGame ();

	}


	//	完成游戏
	public void CompleteGame()
	{
		uimanager.OpenPanel (UITYPE.gamecomplete);
	}


	//	加分
	public void AddScore(int newvalue){
		uimanager.normaltest2.score += newvalue;
	}

	//	时间
	public void Addtime()
	{
		uimanager.normaltest2.timer += Time.time;
	
	}



	void Update () {


		//	时间
		if (state!=pausestate.pause) {
			Addtime ();
		}

		//	限制速度
		playermanager.mariomovement.SetForRun( playermanager.mariomovement.rigidbody.velocity.z<mariomaxvelocity.z);


			
		 }






}
