using UnityEngine;
using System.Collections;

public class LoadResDemo : MonoBehaviour {
	
	public FistCubeStandOn fistcubestandon;
	public TestNormalPanel normalpanel;
	public TestPauseGamePanel pausepanel;
	public AudioManager audiomanager;
	public StartSceneUimanager startsceneuimanager;
	public PlayerManager playermanager;
	public GameComplete[] gamecomplete;
	public InputManager inputmanager;
	public CameraControll cameracontroll;
	public CollisionManager collisionmanager;
	public CubeControll[] hingeJoints;
	public CubeControll cubecontrll;
	public GameManager gamemanager;
	public TestUImanager testuimanager;
	public marioChangeColor mariochangecolor;
	public mariomovement mariomovement;
	private string cavaspush = "Canvas";
	private string gamecontrollpush = "GameControll";
	private string playerpush = "Player";
	private string cubefloorpush = "CubeFloor";
	private string spherepush="Sphere";
	private string Audiomanager = "Audiomanager";

	void Awake () {

		Object Audiomanangerprb = Resources.Load (Audiomanager,typeof(GameObject));
		GameObject Audiomananger = Instantiate (Audiomanangerprb )as GameObject;
		audiomanager = Audiomananger.GetComponent<AudioManager> ();


		Object Spherepreb = Resources.Load (spherepush);
		GameObject sphere = Instantiate (Spherepreb)as GameObject;

		Object cubefloorpreb =Resources.Load (cubefloorpush,typeof(GameObject));
		GameObject cubefloor = Instantiate (cubefloorpreb)as GameObject;

		Object cavaspreb = Resources.Load (cavaspush, typeof(GameObject));
		GameObject canvas = Instantiate (cavaspreb)as GameObject;

//		normalpanel = canvas.GetComponent<TestNormalPanel> ();
//		pausepanel=canvas.GetComponent<TestPauseGamePanel> ();
//
//		normalpanel

		Object gamecontrollpreb = Resources.Load (gamecontrollpush, typeof(GameObject));
		GameObject gamecontroll = Instantiate (gamecontrollpreb)as GameObject;

		Object playerpreb = Resources.Load (playerpush, typeof(GameObject));
		GameObject player = Instantiate (playerpreb)as GameObject;
		gamemanager = gamecontroll.GetComponent<GameManager> ();
		testuimanager = canvas.GetComponent<TestUImanager> ();
		fistcubestandon = gamecontroll.GetComponentInChildren<FistCubeStandOn> ();

		playermanager = player.GetComponent<PlayerManager> ();

//		testuimanager.audiomanager = audiomanager;
		gamemanager.playermanager = playermanager;
		playermanager.gamemanager = gamemanager;
		gamemanager.playermanager.mariomovement.playerRigidbody = player.GetComponent<Rigidbody> ();
		testuimanager.gamemanager = gamemanager;
		gamemanager.uimanager = testuimanager;


		collisionmanager = cubefloor.GetComponent<CollisionManager> ();
		collisionmanager.fistcubestandon = fistcubestandon;
		gamemanager.collisionmanager = collisionmanager;
		collisionmanager.gamemanager = gamemanager;




//		gamemanager.mmcc = mariochangecolor;
//		gamemanager.mariorbin = player.GetComponent<Rigidbody> ();
//		gamemanager.playerMove = mariomovement;

//		mariomovement.gamemanager = gamemanager;

		inputmanager = gamemanager.GetComponent<InputManager> ();
		inputmanager.gamemanager = gamemanager;
//		inputmanager.mariochange = mariochangecolor;
		inputmanager.mariomm = playermanager.mariomovement;

//		GameObject A = GameObject.Find ("CubeFloor");
//		hingeJoints = A.GetComponentsInChildren<CubeControll> ();
		foreach (CubeControll joint in cubefloor.GetComponentsInChildren<CubeControll> ()) {
			if (joint!=null) {
//				joint.gamemanager = gamemanager;
//				joint.changecolor = mariochangecolor;
				joint.marioScore = gamemanager;
				joint.collisionmanager = collisionmanager;
			}

		}

		GameObject camera = GameObject.Find ("Main Camera");
		cameracontroll = camera.GetComponent<CameraControll> ();

			cameracontroll.target = player.transform;

			



	
//		GameObject sphere = GameObject.Find ("Sphere");
		gamecomplete = sphere.GetComponentsInChildren<GameComplete> ();
		foreach (GameComplete gamecompletes in gamecomplete)
		{
			gamecompletes.collisionmanager = collisionmanager;
		}

//			gamecomplete.gamemanager = gamemanager;



	}



	void Update () {
	
	}
}
