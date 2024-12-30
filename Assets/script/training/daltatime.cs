using System.Collections;
using System.Collections.Generic;
using Assignment18;
using UnityEngine;

public class daltatime : MonoBehaviour
{
    public float speed = 4f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       // transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
        //number of frame 
        Debug.Log(Time.frameCount / Time.time);
        float xNew = Mathf.Sin(Time.time*4);
        //transform.position += new Vector3(xNew * Time.deltaTime * 4f, transform.position.y, transform.position.z);
        //transform.rotation = Quaternion.Euler(new Vector3(xNew * 45f, xNew * 45f, 0));
        //transform.localScale = new Vector3(1, 1, 1) * xNew + new Vector3(3, 3, 3);
        float xN = Mathf.PingPong(Time.time*10, 8)-5;//linear
        transform.position = new Vector3(xN , transform.position.y, transform.position.z);
        Debug.Log(xN);
    }
}
