using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newSpell : Spell
{
    public override void Cast()
    {
        Debug.Log("Casting a ShadowSpell");
      
    }
    // Start is called before the first frame update
    void Start()
    {
        Cast();
        Cast("Teemo");
        Cast("Teemo", 50);
    }
} // End NewSpell
