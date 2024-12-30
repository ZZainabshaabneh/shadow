using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public float minScale = 0.1f;
    public float maxScale = 0.9f;
    private float scaleFactor;
    float speed = 0.25f;

    void Start()
    {
        scaleFactor = minScale;
    }


    void Update()
    {

        if (Input.GetKey(KeyCode.D))
        {
            scaleFactor += speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            scaleFactor -= speed * Time.deltaTime;
        }


        scaleFactor = Mathf.Clamp(scaleFactor, minScale, maxScale);

        // Apply the scale to the GameObject
        transform.localScale = Vector3.one * scaleFactor;
    }
}
