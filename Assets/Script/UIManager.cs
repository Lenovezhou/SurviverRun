using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class UIManager : MonoBehaviour {
	public Button startbutton,pausebutton;
	public GameManager gameControll;
	Animator gamestartanim;

	void Start () {
		gamestartanim = GetComponent<Animator> ();
	}
	
	public void PauseClick(){
		Debug.Log ("PauseGame");
		gameControll.PauseGame ();
	}
	public void Gamestart(){
		gameControll.PauseGame ();
		Debug.Log ("let'sGo");

	}
	public void BackHome(){
		gameControll.HomePage();
	}
	public void ReturnGame(){
		gameControll.PauseGame ();
	}
	void Update () {
	
	}
}
