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
	float forwardforce=5f,Deathdeep=-10f;
	public float Firsttime,Seconedtime;
	float timer1=0f,timer2=0f;
	Vector3 vv = new Vector3 (0f, 5f, 0f);
	public bool ForRun;
	public bool isJump=false;
	void Start () {
		Debug.Log ("name"+gameObject);
//		ForRun = true;
//		 playerjump pj=playerjump.run;                                    //赋值后未被使用
		
		marioanim = GetComponent<Animator> ();
		_rb = GetComponent<Rigidbody> ();
		SpereSpped =transform.forward*forwardforce;

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
			Debug.Log ("Jump1");
			_rb.AddForce (upv);
			marioanim.SetBool ("jump_1",true);
		}

	}
	//	条件与第一次起跳相联系所以进入的条件应该一样
	public void FirstJumpUp(){
		if (pj==playerjump.run) {
			pj = playerjump.jump_1;
			timer1 = 0f;
		}

	}
	//	第二次起跳
	public void SecendJump()
	{
		if ( pj==playerjump.jump_1&&Time.timeScale!=0&&timer2<Firsttime) {
			timer2 += Time.deltaTime;
			pj = playerjump.jump_2;
			_rb.AddForce (upv);
			marioanim.SetBool ("jump_1",false);
			marioanim.SetBool ("jump_2",true);
			Debug.Log ("Jump2");
			timer2 = 0f;
		}

	}




}
   