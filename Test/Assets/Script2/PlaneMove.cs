using UnityEngine;
using System.Collections;

public class PlaneMove : MonoBehaviour {
	public float moveSpeed = 20f;

	// Update is called once per frame
	void Update () {
		transform.Translate (0, 0, moveSpeed * Time.deltaTime);
	}
}
