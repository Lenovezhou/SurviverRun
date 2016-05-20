using UnityEngine;
using System.Collections;

public class AudioManager : MonoBehaviour {

	public GameManager gamemanager;
	public AudioSource audiosource;
	void Start () {
		audiosource = GetComponent<AudioSource> ();

	}

	//	播放音乐
	public void PlayMusic()
	{
		audiosource.Play ();
	}


	void Update () {
//		audiosource.Play ();
	}
}
