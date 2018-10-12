using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMake : MonoBehaviour {

	public GameObject missile;
	public Transform[] pos;
	public float shootTime = 0.1f;
	float addTime = 0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		addTime += Time.deltaTime;

		if (addTime > shootTime) {
			//Shoot();
			addTime = 0f;
		}
		if (Input.GetButtonDown("Fire1"))// (KeyCode.Space)) {
			Shoot();
	}
	void Shoot()
	{
		for (int i =0; i < pos.Length; i++)
			Instantiate (missile, pos[i].position, pos[i].rotation);
	}
}
