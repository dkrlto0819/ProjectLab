using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulMake : MonoBehaviour {

    public GameObject Bullet;
    public Transform[] pos;
    public float shootTime = 0.2f;
    float addTime = 0.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //addTime += Time.deltaTime;
        //if(addTime>shootTime){
        //    Shoot();
        //    addTime = 0f;
        //}

        if(Input.GetButtonDown("Fire1")){
            Shoot();
        }
	}

    void Shoot(){
        for (int i = 0; i < pos.Length; ++i)
            Instantiate(Bullet, pos[i].position, pos[i].rotation);
    }
}
