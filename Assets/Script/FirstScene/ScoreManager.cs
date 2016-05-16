using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class ScoreManager : MonoBehaviour {
	Text ScoreText;

	int Score;
	void Start () {
		ScoreText =GetComponent<Text> ();
	}
	public void AddScore(int newvalue){
		Score+=newvalue;
		ScoreText.text = "Score:" + Score;
	}

	void Update () {
	
	}
}
