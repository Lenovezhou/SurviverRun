using UnityEngine;
using System.Collections;

public class CameraControll : MonoBehaviour {
	public Transform target;
	Vector3 mi;
//	Rigidbody rrb1;
	public float a=5f;
	void Start () {
		mi = transform.position - target.position;
//		rrb1 = GetComponent<Rigidbody> ();
	}
	

	void FixedUpdate () {
		Vector3 campos = mi + target.position;
		campos.y = Mathf.Lerp(transform.position.y,campos.y,a*Time.deltaTime);
		transform.position = campos;
	}
}
