using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    // Start is called before the first frame update
    float speed = 3f;

    void Start()
    {
        Camera.main.backgroundColor = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 mousePosition = Input.mousePosition;
            mousePosition.z = 10;//when the mouse move the object will move with it 
            Vector3 unitypos = Camera.main.ScreenToWorldPoint(mousePosition);
            //transform.position = unitypos;
            //Debug.Log(mousePosition); 
            //smoothing and motion
            transform.position = Vector3.Lerp(transform.position, unitypos, speed * Time.deltaTime);
        }

    }
}
