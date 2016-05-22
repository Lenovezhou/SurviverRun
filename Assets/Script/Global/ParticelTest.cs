using UnityEngine;
using System.Collections;

public class ParticelTest : MonoBehaviour {


//	public PlayerManager playermanager;
	public ParticleSystem playerparticle;


	void Start () {
		GameObject whitsmorke = gameObject.FindInChildren ("WhiteSmoke");
		playerparticle = whitsmorke.GetComponent<ParticleSystem> ();
		playerparticle.Clear ();
		playerparticle.Play ();
		ChangeParticleColor (Color.red);

	}
	//	粒子颜色
	public void ChangeParticleColor(Color particelcolor)
	{
		playerparticle.startColor = particelcolor;
	}

	void Update () {
	
	}
}
