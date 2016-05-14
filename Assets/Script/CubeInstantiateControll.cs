using UnityEngine;
using System.Collections;

public class CubeInstantiateControll : MonoBehaviour {
	public Transform mariopos;
	public GameObject Cubeprefab;
	public CubeControll CubemanagerC;
	int CubeConte;
	Vector3 SetCubeposition;
	Vector3 targetpos;
	void Start () {
		CubemanagerC= GetComponent<CubeControll> ();
		ProduceCube ();

	}
	
	void ProduceCube(){
		GameObject pF =Instantiate (Cubeprefab);
		CubeControll FCC = pF.GetComponent<CubeControll> ();
		FCC.mariomove =CubemanagerC.mariomove;
		FCC.marioScore = CubemanagerC.marioScore;
		FCC.Formariorb = CubemanagerC.Formariorb;
		FCC.changecolor = CubemanagerC.changecolor;
		FCC.gamemanager = CubemanagerC.gamemanager;
		FCC.CubeColor = CubemanagerC.CubeColor;	

			
	}

	void Update () {
		


	}
}
