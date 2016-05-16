using UnityEngine;
using System.Collections;

public class CubeControll : MonoBehaviour {

	public Material[] CubeMaterial;
	public mariomovement mariomove;
	public mariocolor CubeColor;
	MeshRenderer CubeMaterialset;
	public marioChangeColor changecolor;
	bool iscolision;
	public Rigidbody Formariorb;
	public GameManager marioScore;
	public GameManager gamemanager;

	int ScoreValue=10;

	void Start () {
		gamemanager.cubemanager = this;
		changecolor.mc = mariocolor.red;
		CubeColor = mariocolor.red;
		CubeMaterialset = GetComponent<MeshRenderer> ();


		//	随机出不同颜色的Cube
		int cubeMaterialindeix =Random.Range(0,CubeMaterial.Length);
		if (cubeMaterialindeix == 0) {
			CubeColor = mariocolor.red;
			CubeMaterialset.material = CubeMaterial [cubeMaterialindeix];
			//			Debug.Log ("index=0");
		} else {
			CubeColor = mariocolor.yellow;
			CubeMaterialset.material = CubeMaterial [cubeMaterialindeix];
		}
	}
//
//
//	//死亡
//	void Dead()
//	{
//		return;
//		GOcotroll.GameOver ();
//		mariomove.enabled = false;
//		changecolor.enabled = false;
//	}
	//	判定碰撞的物体Mario的颜色是否与Cube相同，且标记碰撞次数
	void OnCollisionEnter(Collision other){
		gamemanager.playerMove.SetJumpOver ();
		gamemanager.playerMove.MarioAnimator (playerjump.run);
		if (CubeColor ==changecolor.mc&& !iscolision ) {
//				return;
			marioScore.AddScore (ScoreValue);
			iscolision = true;
		} else if(CubeColor !=changecolor.mc){
			gamemanager.Dead ();
//			Debug.Log ("if");
			}	
	//	摧毁自己
//		Destroy (gameObject,3f);

	}
//	public void CollisionState()
//	{
//		mariomove.pj = playerjump.run;
//		mariomove.marioanim.SetBool ("jump_1",false);
//		mariomove.marioanim.SetBool ("jump_2",false);
//	}


	void OnCollisionStay(Collision other)
	{
		
		if (CubeColor != changecolor.mc) 
		{
			gamemanager.Dead ();
			Debug.Log ("不相等");
		} 
	}


	void Update () {

	}
}
