using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class InputManager : MonoBehaviour {
//	public marioChangeColor mariochange;
	public mariomovement mariomm;
	public GameManager gamemanager;
	pausestate puse;
	void Start () {
	
	}
	
	public float speed = 0.1F;
	void Update() {
		if (gamemanager.state==pausestate.unpause) {
			//------------Button
			if (Input.GetButton ("Jump"))
			{
				mariomm.RigidbodyMove ();
			}
			if (Input.GetButtonUp ("Jump")) {
				mariomm.FirstJumpUp ();
			}
			if (Input.GetButtonDown ("Fire1")) {
				//			mariochange.ischange = true;
			//	mariochange.ChangColor ();
			}	
			//--------------Touch
			#if UNITY_EDITOR || UNITY_IOS
			//	bool IsPonterOverGameObject();检查是否点击clisked on 在UI上
			if (!EventSystem.current.IsPointerOverGameObject())
			{
				
				if (Input.GetMouseButtonDown (0)) {
					if(Input.mousePosition.x >= Screen.width*0.5f)
					{
						mariomm.RigidbodyMove ();
					}
				}
				if (Input.GetMouseButtonUp (0)) {
					mariomm.FirstJumpUp ();
				}
				if (Input.GetMouseButtonDown (0)) {
					if(Input.mousePosition.x < Screen.width*0.5f)
					{
						gamemanager.playermanager.mariochangecolor.ChangeColor ();
					}
				}
			}

			#elif UNITY_IOS
			if ((Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Moved))
			{
				if (Input.GetTouch (0).position.x >= Screen.width * 0.5f || Input.mousePosition.x >= Screen.width*0.5f)
				{
					mariomm.RigidbodyMove ();
				}
			}
			if (Input.touchCount > 0 
				&& (Input.GetTouch (0).phase == TouchPhase.Canceled || Input.GetTouch (0).phase == TouchPhase.Ended))
			{
				mariomm.FirstJumpUp ();
			}
			if (Input.touchCount > 0 && (Input.GetTouch (0).phase == TouchPhase.Began||Input.GetTouch(0).phase==TouchPhase.Moved))
			{
				if (Input.GetTouch (0).position.x < Screen.width * 0.5f || Input.mousePosition.x < Screen.width*0.5f)
				{
					mariochange.ChangColor ();
				}
			}


			#endif

			//----------------MouseButton
			//解决按住后与地面接触直接进行二段跳
//			if (EventSystem.current.IsPointerOverGameObject(Input.GetTouch(0).fingerId))
//				#else



		}

		if (Input.GetKeyDown(KeyCode.Escape)) {
			gamemanager.PauseGame ();
		}
		if (Input.GetKeyDown(KeyCode.Q)) {
			Application.LoadLevel (Application.loadedLevel);
		}
//		if (Input.GetKeyDown(KeyCode.R)) {
//			gamemana.Restartgame ();
//		}

//		if ((Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Moved)) {
//			Debug.Log (Input.GetTouch (0).position);
//			Screen.width;
//			Screen.height;
//			Jump ();
//		}
//		if (Input.GetMouseButton (0)) {
//			Debug.Log (Input.mousePosition);
//						Screen.width;
//						Screen.height;
//						Jump ();
//		}

	}


}
