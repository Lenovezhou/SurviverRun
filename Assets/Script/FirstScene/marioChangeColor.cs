using UnityEngine;
using System.Collections;
public enum mariocolor{
	red,
	yellow
}
public class marioChangeColor : MonoBehaviour {
	public Material marioMaterialRed,marioMaterialYellow;
	public mariocolor mc;
	SkinnedMeshRenderer marioskin;
	public bool ischange=false;
	void Start () {
		GameObject m001 =GameObject.Find ("mario001");
		marioskin =m001.GetComponent<SkinnedMeshRenderer> ();
		mc = mariocolor.red;
		marioskin.material = marioMaterialRed;
	}
	

	void Update () {

	}
	public void ChangColor(){
		if ( Time.timeScale != 0) {
			Selectcolor();

			if (mc==mariocolor.yellow) {
				marioskin.material = marioMaterialYellow;
			}else {
				marioskin.material = marioMaterialRed;
			}
//			ischange = false;

		} 
	}

	void Selectcolor(){
		mc = mc == mariocolor.red ? mariocolor.yellow : mariocolor.red;
	}
}
