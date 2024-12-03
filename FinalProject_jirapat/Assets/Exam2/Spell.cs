using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class Spell : MonoBehaviour
{   
    public virtual void Cast()
    {
        Debug.Log("Casting a ordinary spell");
    }

    public void Cast(string Target)
    {
        Debug.Log($"Casting a spell on: {Target}!");
    }

    public void Cast(string Target, int damage)
    {
        Debug.Log($"Casting a spell on {Target}! with power level: {damage}");
    }
    private void Start()
    {
        Debug.Log("Spell-Casting Simulation Started");
        Cast();
    }

}// End Abstract Spell
