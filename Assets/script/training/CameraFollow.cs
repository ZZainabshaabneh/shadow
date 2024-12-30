using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform targetObject;
    private Vector3 difference;
    public float cameraSpeed = 0.07f;
    public bool LookAt = true;
    void Start()
    {
        difference = transform.position - targetObject.position;
        Debug.Log(difference);
    }
    void LateUpdate()
    {
        //transform.position = targetObject.transform.position;
        Vector3 Npos = Vector3.Lerp(transform.position, targetObject.position + difference, cameraSpeed);//divide the distaice 0.3
        transform.position = Npos;
        if (LookAt)
        {
            transform.LookAt(targetObject);
        }

    }
}
