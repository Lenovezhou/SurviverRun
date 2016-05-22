using UnityEngine;
using System.Collections;

public class AudioManager : MonoBehaviour {
	public AudioClip[] audioclip;
	public static AudioManager a;
	public GameManager gamemanager;
	public  AudioSource[] audios;
	private static AudioManager audiosource;
	public static AudioManager GetInstance()
	{
		if (audiosource==null) {
			audiosource = a;		//静态方法中不能使用this
		}	
		return audiosource;
	}
	void Awake () {
		audios = gameObject.GetComponents<AudioSource> ();

		//	prefab,别的都在start中调用
		a = this;
	}

	//	播放音乐
	public void PlayMusic(int index)
	{
		audios[0].clip=audioclip[index];	
		audios[0].Play ();
	}


	//	背景音乐
	public void PlayBackgroundUnpause()
	{
		audios[1].clip=audioclip[7];
		audios [1].Play ();
	}
	public void PlayBackground()
	{
		audios[1].clip=audioclip[7];
		audios [1].Stop ();
		audios [1].Play ();
	}
	public void PlayBackgroundPause()
	{
		audios[1].clip=audioclip[7];
		audios [1].Pause();
	}


	void Update () {
//		audiosource.Play ();
	}
}
