using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveobject : MonoBehaviour
{
    float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        Camera.main.backgroundColor = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 mospos = Input.mousePosition;
            mospos.z = 10;
            Vector3 inunitypos = Camera.main.ScreenToWorldPoint(mospos);
            transform.position = Vector3.Lerp(transform.position, inunitypos, speed * Time.deltaTime);
        }
    }
}
