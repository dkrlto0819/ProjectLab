using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P38Rotate : MonoBehaviour {
    public float turnSpeed = 60.0f;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float v = Input.GetAxis("Vertical");
        float h = Input.GetAxis("Horizontal");
        Vector3 rotateDir = new Vector3(v, 0, -h);
        transform.Rotate(rotateDir * turnSpeed * Time.deltaTime);
	}
}
