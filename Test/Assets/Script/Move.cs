using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {
	float moveSpeed = -11.02f;
	public float rotateSpeed = 100.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float h = Input.GetAxis ("Horizontal");
		float v = Input.GetAxis ("Vertical");
		transform.Translate (-v * moveSpeed * Time.deltaTime,0,0);
		transform.Rotate (0, h * rotateSpeed * Time.deltaTime, 0);
	}
}





