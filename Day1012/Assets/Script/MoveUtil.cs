using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUtil
{
    //Function to Move Chracter to destination 
    public static float MoveFrame(CharacterController controller, Vector3 target, float moveSpeed, float rotateSpeed){
        Transform t = controller.transform;
        Vector3 dir = target - t.position;
        Vector3 dirXZ = new Vector3(dir.x, 0.0f, dir.z);
        Vector3 targetPos = t.position + dirXZ;
        Vector3 framePos = Vector3.MoveTowards(t.position, targetPos, moveSpeed*Time.deltaTime);
        controller.Move(framePos - t.position);

        RotateToDir(t, target, rotateSpeed);

        return Vector3.Distance(framePos, targetPos);
    }

    public static void RotateToDir(Transform self, Vector3 target, float rotateSpeed){
        Vector3 dir = target - self.position;
        Vector3 dirXZ = new Vector3(dir.x, 0.0f, dir.z);
        if(dirXZ==Vector3.zero){
            return;
        }
        self.rotation = Quaternion.RotateTowards(self.rotation, Quaternion.LookRotation(dirXZ), rotateSpeed*Time.deltaTime);
    }
}
