using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;

    float highestY;
    //public Transform target2;

    private void LateUpdate()
    {
        if (target == null) return;

        if (target.position.y > highestY)
            highestY = target.position.y;
        transform.position = new Vector3(target.position.x, highestY, transform.position.z);
    }
}
