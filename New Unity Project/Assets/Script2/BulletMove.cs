using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour {
	public float moveSpeed = 60.0f;
	
	void Awake()
	{
		Destroy (gameObject, 0.5f);
	}
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (new Vector3 (-moveSpeed, 0, 0) * Time.deltaTime);
	
	}
}
