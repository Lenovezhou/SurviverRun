using UnityEngine;
using System.Collections;

public class CloudeControll : MonoBehaviour {

	Vector3 cloudmove;
	public GameObject prefab_prefab;
	public Transform prefabtransform;
	void Start () {
		InvokeRepeating ("InstanceCloud",3f,10f);
	}


	 void InstanceCloud()
	{
//		yield return new WaitForSeconds (3f);
		for (int i = 0; i < 5; i++) {
			GameObject prefab=Instantiate (prefab_prefab)as GameObject;
		prefab.transform.position = new Vector3 (
			Random.Range(prefabtransform.position.x,prefabtransform.position.x+600),
			Random.Range(prefabtransform.position.y-400,prefabtransform.position.y+300),
			Random.Range(prefabtransform.position.z-100,prefabtransform.position.z+400)
//			prefabtransform.position.y,
//			prefabtransform.position.z
		);
		prefab.transform.rotation = Quaternion.identity;
//			yield return new WaitForSeconds (5f);
	}
	}
	void Update () {

	}
}
