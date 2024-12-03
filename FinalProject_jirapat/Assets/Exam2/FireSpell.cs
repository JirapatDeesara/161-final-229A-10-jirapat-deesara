using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSpell : Spell
{
    public override void Cast()
    {
        Debug.Log("Casting an Fire blast! The fire consume all!");
    }
    // Start is called before the first frame update
    void Start()
    {
        Cast();
        Cast("Chicken");
        Cast("Chicken", 99);
    }

}// End FireSpell
