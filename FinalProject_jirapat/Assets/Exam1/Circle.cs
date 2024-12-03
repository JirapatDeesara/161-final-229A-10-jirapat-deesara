using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : Shape
{
    private float radius;
    public override float CalculateArea()
    {
        return radius = 3.14*2.2*2.2;
    }

    public override void Resize()
    {
        Debug.Log("Resize Circle to the info");
    }

    // Start is called before the first frame update
    void Start()
    {
        Init("Circle");
        Resize();
    }

   
}
