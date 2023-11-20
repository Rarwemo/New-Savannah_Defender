using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform lookAt;
    public Vector3 offset ;
    public Vector3 rotation;

    public bool IsMoving { set; get; }


    private void LateUpdate()
    {
        /*if (!IsMoving)
        {
            return;
        }*/
        transform.position = lookAt.position + offset;
      
    }
}