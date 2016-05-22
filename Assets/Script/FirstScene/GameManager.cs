using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public enum pausestate{
	pause,
	unpause
}
public class GameManager : MonoBehaviour {
	
	public CollisionManager collisionmanager;
	public StartSceneUimanager startsceneuimanager;
	public CubeControll cubemanager;
	public PlayerManager playermanager;
	public TestUImanager uimanager;
	public pausestate state=pausestate.pause;
	bool isDead;

	void Start () {
		ReStartGame ();
	}



	//	暂停游戏
	public void PauseGame()
	{
		if (state == pausestate.unpause&&!isDead) 
		{
			playermanager.particeltest.playerparticle.Pause();
			AudioManager.GetInstance ().PlayBackgroundPause();
			playermanager.mariomovement.SetForIsKinematic (true);
			state = pausestate.pause;
		}
	}



	//	首次开始游戏
	public void ReStartGame()
	{
		startsceneuimanager = GetComponent<StartSceneUimanager> ();
		AudioManager.GetInstance ().PlayBackground ();
		playermanager.mariomovement.SetForIsKinematic (false);
		uimanager.normaltest2.ResetST ();						//	重置时间和分数
		playermanager.mariochangecolor.ResetColor ();
		isDead = false;
		playermanager.mariomovement.Reset();
		playermanager.mariomovement.pj = playerjump.run;
//		SetAnimator ("Start");
		state = pausestate.unpause;
	}





	public void ContinueGame()
	{
//		AudioManager.GetInstance ().PlayBackground ();
		playermanager.mariomovement.SetForIsKinematic (false);
		state = pausestate.unpause;
	}



	//	游戏结束
	public void Dead(){
		AudioManager.GetInstance ().PlayBackground ();
		isDead = true;
		ReStartGame ();
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
			
	}






}
