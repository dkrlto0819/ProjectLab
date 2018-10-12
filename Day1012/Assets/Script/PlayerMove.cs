using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum CharacterState{
    Idle = 0,
    Run,
    Attack,
    Max
}

public class PlayerMove : MonoBehaviour {
    public float moveSpeed = 3.0f;
    public float rotateSpeed = 150.0f;
    public Animator ani;
    public float attackTime = 0.0f;
    public CharacterController controller;
    public Vector3 movePos;
    public int layerMask;
	void Start () {
        ani = GetComponent<Animator>();
        controller = GetComponent<CharacterController>();
        movePos = controller.transform.position;
        layerMask = (1 << 8) + (1 << 9);
        movePos = controller.transform.position;
    }
	
	void Update () {
        RaycastHit hitInfo;
        if(Input.GetMouseButton(0)){
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hitInfo, 100.0f, layerMask))
            { // 충돌이 있나 체크 
                //int layer = hitInfo.collider.gameObject.layer;
                //Debug.Log("layer" + layer + "and" + hitInfo.point); 어차피 찍기 위해서임
                int layer = hitInfo.collider.gameObject.layer;
                if (layer == 9){
                    Destroy(hitInfo.collider.gameObject);
                    return;
                }
                movePos = hitInfo.point;
                ani.SetInteger("state", 1);
            }
        }

        if(ani.GetInteger("state")==1){
            if (MoveUtil.MoveFrame(controller, movePos, moveSpeed, rotateSpeed) == 0) {
                ani.SetInteger("state", 0);
            }
        }
        //if(transform.position != movePos){
        //    Vector3 normal = movePos - transform.position;
        //    normal.Normalize();
        //    controller.Move(normal * moveSpeed*Time.deltaTime);
        //    ani.SetInteger("state", 1);
        //}else{
        //    ani.SetInteger("state", 0);
        //}

        //float h = Input.GetAxis("Horizontal");
        //float v = Input.GetAxis("Vertical");

        ////if (ani.GetInteger("state") == 2)
        ////{
        ////    attackTime += Time.deltaTime;
        ////    if (attackTime > 1.0f)
        ////        ani.SetInteger("state", 0);
        ////    return;
        ////}
        ////if (Input.GetButtonDown("Fire1"))
        ////{
        ////    ani.SetInteger("state", 2);
        ////    attackTime = 0.0f;
        ////    return;
        ////}
        //if (h != 0.0f || v != 0.0f)
        //{  
        //    controller.Move(transform.forward * v * moveSpeed * Time.deltaTime);
        //    transform.Rotate(0, h * rotateSpeed * Time.deltaTime, 0);
        //    ani.SetInteger("state", 1);
        //}
        //else
        //{
        //    ani.SetInteger("state", 0);
        //}
    }
}
