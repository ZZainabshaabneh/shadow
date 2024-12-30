using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment27{
public class CallbyrefCallbyvalue : MonoBehaviour
{
    void Start()
    {
        int a = 2;
        int b = 5;
        AddValue(a);
        Debug.Log(a);

        AddValuebyRef(ref b);

        Debug.Log(b);

        int c;
        OutValue(out c);
        Debug.Log(c);

    }

    public void AddValue(int number)
    {
        number += 10;

    }

    public void AddValuebyRef(ref int number)
    {
        number = number + 10;

    }
    public void OutValue(out int number)
    {
        number = 10;
        

    }
}
}