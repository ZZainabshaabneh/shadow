using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toy : MonoBehaviour
{
    // Start is called before the first frame update
    public float dbaba = 0.01f;
    public float angleInc = 0.01f;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {

            dbaba += angleInc;
            transform.position += new Vector3(dbaba, 0, 0);
            Debug.Log("1");

        }
        if (Input.GetKey(KeyCode.S))
        {

            dbaba += angleInc;
            transform.position -= new Vector3(dbaba, 0, 0);
            Debug.Log("1");

        }
        if (Input.GetKey(KeyCode.A))
        {

            dbaba += angleInc;
            transform.position -= new Vector3(0, 0, dbaba);
            Debug.Log("1");

        }
        if (Input.GetKey(KeyCode.D))
        {

            dbaba += angleInc;
            transform.position += new Vector3(0, 0, dbaba);
            Debug.Log("1");

        }
    }
}
