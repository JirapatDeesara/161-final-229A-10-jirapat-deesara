using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceSpell : Spell
{
    public override void Cast()
    {
        Debug.Log("Casting an Ice blizzard storm! Freeze don't move!");
    }
    // Start is called before the first frame update
    void Start()
    {
        Cast();
        Cast("Ghoul");
        Cast("Ghoul", 22);
    }


}// End IceSpell
