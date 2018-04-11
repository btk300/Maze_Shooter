using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour {


	public float damage = 15f;
	public float distance = 150f;
	public float pushpower;
	public Camera fpscam;
	public LayerMask player;

	private Animation gunFire;
	// Use this for initialization
	void Start () {
		gunFire = GetComponent<Animation>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1")) {
			RaycastHit hit;
			if (Physics.Raycast (fpscam.transform.position, fpscam.transform.forward, out hit, distance, player)) {
				gunFire.Play ();
				Debug.Log (hit.transform.name);
				if (hit.rigidbody != null) {
					hit.rigidbody.AddForce (fpscam.transform.forward * pushpower);
				}
			}
		}
	}
}
