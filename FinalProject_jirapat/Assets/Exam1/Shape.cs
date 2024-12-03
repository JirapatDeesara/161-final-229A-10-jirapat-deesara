using OpenCover.Framework.Model;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Shape : MonoBehaviour
{// Circle = Pie * r^2
 // Square = side*side
 // # shapeName: string
    protected string ShapeName;
   
    // Method
    public void Init(string name)
    {
        Debug.Log($"Drawing {name}");
    }

    public abstract float CalculateArea();

    public virtual void Resize()
    {
        Debug.Log("Resizing Shape");
    }

    public void Draw()
    {
        
    }

}//End Shape
