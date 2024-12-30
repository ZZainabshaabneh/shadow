using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorExample : MonoBehaviour
{
    Color color;
    public Color redcolor = Color.red;
   public  Color greencolor = Color.green;
    private Color acolor = new Color(0.5f, 1f, 0.5f);
    //Renderer renderer;
    float timer = 0;
    public float speed = 10;
    Material material ;
    // Start is called before the first frame update
    void Start()
    {
        Camera.main.backgroundColor = Color.magenta;
        Renderer renderer = GetComponent<Renderer>();
        Material material = renderer.material;
        //material.color = color;
        //material.color = acolor;
        //material.color = Color.cyan + Color.white;
       // material.color = new Color(Random.value, Random.value, Random.value);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        // greencolor.a = 0.5f;
        material.color = Color.Lerp(redcolor, greencolor, Mathf.PingPong(timer, 1));
    }
}
