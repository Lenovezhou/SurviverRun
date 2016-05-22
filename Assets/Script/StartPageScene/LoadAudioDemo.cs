using UnityEngine;
using System.Collections;

public class LoadAudioDemo : MonoBehaviour {
	public LogoPanel logopanel;
	public StartSceneUimanager startsceneuimanager;
	public AudioManager audiomanager;
	private string Audiomanager = "Audiomanager";
	void Start () {
		Object Audiomanangerprb = Resources.Load (Audiomanager,typeof(GameObject));
		GameObject Audiomananger = Instantiate (Audiomanangerprb )as GameObject;
//		audiomanager = Audiomananger.GetComponent<AudioManager> ();
//		audiomanager.audios = audiomanager.GetComponent<AudioSource> ();
	

//		GameObject canvas = GameObject.Find ("Canvas");
//		startsceneuimanager =canvas.GetComponent<StartSceneUimanager> ();
//		logopanel = canvas.GetComponentInChildren<LogoPanel> ();
//		logopanel.audiomanager = audiomanager;
//		startsceneuimanager.audiomanager = audiomanager;

	}
	

	void Update () {
	
	}
}
