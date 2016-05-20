using UnityEngine;
using System.Collections;

public class LoadAudioDemo : MonoBehaviour {
	public StartSceneUimanager startsceneuimanager;
	public AudioManager audiomanager;
	private string Audiomanager = "Audiomanager";
	void Start () {
		Object Audiomanangerprb = Resources.Load (Audiomanager,typeof(GameObject));
		GameObject Audiomananger = Instantiate (Audiomanangerprb )as GameObject;
		audiomanager = Audiomananger.GetComponent<AudioManager> ();
		GameObject canvas = GameObject.Find ("Canvas");
		startsceneuimanager =canvas.GetComponent<StartSceneUimanager> ();
		startsceneuimanager.audiomanager = audiomanager;
	}
	

	void Update () {
	
	}
}
