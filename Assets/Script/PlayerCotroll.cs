using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public enum PlayerColor{
	Red,
	Yellow
}
public class PlayerCotroll : MonoBehaviour {
	
	public MeshRenderer playerMesh;
	public Material playerMaterialred,playerMaterialgreen;
	public PlayerColor pcg;

//	float timer;
	void Start () {
		pcg = PlayerColor.Yellow;


		GameObject player = GameObject.FindWithTag ("Player");
		playerMesh = player.GetComponentInChildren<MeshRenderer> ();
		playerMesh.material = playerMaterialgreen;
	}
	

	void Update () {
//		timer += Time.deltaTime;
		if (Input.GetButtonDown("Fire1")&&Time.timeScale!=0) {
			ChangeColor ();
			if (pcg == PlayerColor.Red) {
				playerMesh.material = playerMaterialred;
			} else {
				playerMesh.material = playerMaterialgreen;
			}

		}
	}
	void ChangeColor(){
		pcg = pcg == PlayerColor.Red ? PlayerColor.Yellow : PlayerColor.Red;
	}

}
