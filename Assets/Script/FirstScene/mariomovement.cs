using UnityEngine;
using System.Collections;
//	枚举出Mario的三种状态用于限制他的连续跳跃
public enum playerjump{
	run,
	jump_1,
	jump_2
} 
public class mariomovement : MonoBehaviour {
	
	public GameManager gamemanager;
	public playerjump pj;
	public Animator marioanim;
	public Vector3 forwardv, upv,downv;
	Rigidbody _rb;
	Vector3 SpereSpped;
	float forwardforce=5f,Deathdeep=-10;
	public float Firsttime,Seconedtime;
	float timer1=0f,timer2=0f;
	Vector3 vv = new Vector3 (0f, 5f, 0f);
	public bool ForRun;
	private bool isJump_1_over=false;
	public string animatorname;
	void Start () {
//		ForRun = true;
		 playerjump pj=playerjump.run;                                    //赋值后未被使用
		
		marioanim = GetComponent<Animator> ();
		_rb = GetComponent<Rigidbody> ();
		SpereSpped =transform.forward*forwardforce;

	}
	
	public void SetForRun(bool a)
	{
		ForRun = a;
	}


	void Update () {
		if (gamemanager.state==pausestate.unpause) {
			Run ();
			isOver ();
		}

	}
	//	给Mario添加向前的力，为了让Mario能快速下降给它持续添加向下的力
	public void Run(){
		if (ForRun) {
			_rb.AddForce (forwardv);
		}
		_rb.AddForce (downv);

	}

	//	给GameManager中的RestarGame调用
	public void Reset(){
		transform.position = Vector3.zero;
	
	}
	//	判断Mario是否落入底层
	void isOver(){
		if (transform.position.y<Deathdeep) {
			gamemanager.Dead ();
		}
	}

	public void SetJumpOver()
	{
		isJump_1_over = false;
	}

	//	连续跳跃
	public void RigidbodyMove()
	{
		
		FirstJump ();
		SecendJump ();	
	}
	//	连续跳跃的具体方法
	public void FirstJump()
	{

		if ( pj==playerjump.run&&Time.timeScale!=0&&timer1<Firsttime) 
		{
			timer1 += Time.deltaTime;
			_rb.AddForce (upv);
			MarioAnimator (playerjump.jump_1);

			Debug.Log ("jump1",gameObject);
		}

	}
	public void FirstJumpUp(){
		timer1 = 0;
		//		防止进入二段跳
		if (pj == playerjump.jump_1)
		{
			isJump_1_over = true;
		}
	}
	public void SecendJump()
	{
		if ( isJump_1_over&&pj==playerjump.jump_1&&Time.timeScale!=0&&timer2<Firsttime) {
			isJump_1_over = false;
			timer2 += Time.deltaTime;
			_rb.AddForce (upv);
			MarioAnimator (playerjump.jump_2);
			timer2 = 0f;
			Debug.Log ("jump2");
		}

	}

	//	方法重载， 
	public void MarioAnimator(string name)
	{
		switch(name)
		{
		case "run":
			pj = playerjump.run;
			break;
		case "jump_1":
			pj = playerjump.jump_1;
			break;
		case "jump_2":
			pj = playerjump.jump_2;
			break;
		}
		AnimatorChange (name);
	}

	public void AnimatorChange(string name)
	{
//		marioanim.SetBool (animatorname,false);
		marioanim.SetBool (name,true);
		animatorname = name;
	}


	public void MarioAnimator(playerjump playerjump)
	{
		pj = playerjump;
		string a= playerjump.ToString ();
		AnimatorChange (a);
//		switch(playerjump)
//		{
//		case playerjump.run:
//			AnimatorChange ("run");
//			break;
//		case playerjump.jump_1:
//			AnimatorChange ("jump_1");
//			break;
//		case playerjump.jump_2:
//			AnimatorChange ("jump_2");
//			break;
//		}
	}




}
   