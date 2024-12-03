using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : Shape
{
    private int side;
    public override float CalculateArea()
    {
        float squareArea = side*side;
        return squareArea; 
    }

    public override void Resize()
    {
        Debug.Log("The Square is Resize");
    }

    // Start is called before the first frame update
    void Start()
    {
        Init("Square");
        Resize();
    }


}
