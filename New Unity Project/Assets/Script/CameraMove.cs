using UnityEngine;
using System.Collections;

public class CameraMove : MonoBehaviour {
	public Transform playerTransForm;
	public float smoothTime = 0.7f;
	Vector3 currentVelosity = Vector3.zero;

	// Use this for initialization
	void Awake () {
		playerTransForm =
			GameObject.FindGameObjectWithTag ("Player").transform;
	}
	
	// Update is called once per frame
	void Update () {
		//Vector3.Lerp(transform.position, playerTransForm.position,Time.deltaTime);
		   

		transform.position = Vector3.SmoothDamp (transform.position,
			playerTransForm.position,
			ref currentVelosity, smoothTime);
	}
}
