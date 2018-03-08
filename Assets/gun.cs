using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour {


	public float damage = 15f;
	public float distance = 150f;

	public Camera fpscam;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1")) {
			RaycastHit hit;
			if (Physics.Raycast (fpscam.transform.position, fpscam.transform.forward, out hit, distance)) {
				Debug.Log (hit.transform.name);
			}
		}
	}
}
