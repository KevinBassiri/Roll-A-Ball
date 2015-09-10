using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {


	//Update used once per frame
	void Update(){
		transform.Rotate (new Vector3(15, 35, 40)*Time.deltaTime);
	}

}
