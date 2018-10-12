using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulMove : MonoBehaviour {

    public float moveSpeed = 600f;
	// Use this for initialization
	void Awake () {
        Destroy(gameObject, 0.5f);
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(new Vector3(0, 0, -moveSpeed)*Time.deltaTime);
	}
}
