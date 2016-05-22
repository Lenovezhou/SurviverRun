using UnityEngine;
using System.Collections;
public enum mariocolor{
	red,
	yellow
}

public static class Find{
	public static GameObject FindInChildren(this GameObject obj,string name)
	{
		foreach(Transform obj1 in obj.GetComponentsInChildren<Transform>())
		{
			if (obj1.name==name) {
				return obj1.gameObject;
			}
		}
		return null;
	}
}

public class marioChangeColor : MonoBehaviour {
	public PlayerManager playermanager;
	public Material marioMaterialRed,marioMaterialYellow;
	public mariocolor mc;
	public SkinnedMeshRenderer marioskin;
	public bool ischange=false;
	public ParticelTest particeltest;
	void Start () {
		particeltest = GetComponent<ParticelTest> ();
		GameObject m001 =gameObject.FindInChildren ("mario001");
		marioskin = Find.FindInChildren (m001, "mario001").GetComponent<SkinnedMeshRenderer> ();;
//		marioskin =m001.GetComponent<SkinnedMeshRenderer> ();
		mc = mariocolor.red;
		marioskin.material = marioMaterialRed;
	}

	//	重置颜色
	public void ResetColor()
	{
		if (marioskin!=null&&playermanager!=null) {
			mc = mariocolor.red;
			marioskin.material = marioMaterialRed;
			particeltest.playerparticle.Clear ();
			particeltest.playerparticle.Play ();
			particeltest.ChangeParticleColor (Color.red);
		}

	}


	void Update () {

	}
	public void ChangeColor(){
		if ( Time.timeScale != 0) {
			Selectcolor();

			if (mc==mariocolor.yellow) {
				marioskin.material = marioMaterialYellow;
				particeltest.ChangeParticleColor (Color.yellow);
			}else {
				marioskin.material = marioMaterialRed;
				particeltest.ChangeParticleColor (Color.red);
			}
//			ischange = false;

		} 
	}

	public void CompareColor(mariocolor color)
	{
		if (color!=mc) {
			playermanager.gamemanager.Dead ();
		}
	}


	void Selectcolor(){
		mc = mc == mariocolor.red ? mariocolor.yellow : mariocolor.red;
	}
}
