using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//T.W. code

public class Rotator : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(30,45,15) * Time.deltaTime);
	}
}
