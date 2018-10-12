using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P38Move : MonoBehaviour {
    public float moveSpeed = 20.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(0, 0, moveSpeed * Time.deltaTime);	
	}
}
