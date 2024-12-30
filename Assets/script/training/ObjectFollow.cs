using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectFollow : MonoBehaviour
{
    float angle;
    public float speed = 5f;
    public Transform gameObject;
    //public GameObject gameObject;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(gameObject);
        if (Vector3.Distance(gameObject.position, transform.position) > 0.5f)
        {
            transform.Translate(Vector3.forward * Time.deltaTime, Space.Self);
        }

        // transform.Rotate(Vector3.left,Time.deltaTime*speed,Space.Self);
        // transform.Translate(new Vector3(1 * Time.deltaTime, 0, 0), Space.World);
    }
}

// public Transform[] cubes;
// 1 reference
// public float[] speeds;
// // Start is called before the first frame update

// void Start(){}

// // Update is called once per frame

// void Update()
// {
//     for (int i - 0; i < cubes.Length; 1++){
//     cubes[i].Translate(Vector3.left * speeds[i] * Time.deltaTime);

// }
// }


