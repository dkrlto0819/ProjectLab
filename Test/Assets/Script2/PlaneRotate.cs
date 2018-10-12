using UnityEngine;
using System.Collections;

public class PlaneRotate : MonoBehaviour {
	public float turnSpeed = 60f;
	
	// Update is called once per frame
	void Update () {
		float v = Input.GetAxis ("Vertical");
		float h = Input.GetAxis ("Horizontal");

		Vector3 rotateDir = new Vector3 (v, 0, -h);
		transform.Rotate (rotateDir * turnSpeed * Time.deltaTime);
	
	}
}
