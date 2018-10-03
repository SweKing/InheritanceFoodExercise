using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : Usability
{
    public float damage;
    public bool isShiny;

    public override void Use()
    {
        base.Use();
    }

    public override string UseText()
    {
        return "You hit an ugly-ass troll with " + displayname + ". It has " + uses + " left.";
    }

    public override string NoUsesRemainingText()
    {
        return "you threw a migthy blow, but unfortunately " + displayname + " could not stand being under your posession anymore. It is now broken";
    }

    public string ShinyToString()
    {
        if (isShiny)
            return "Shines like baby-ass";
        else
            return "Is and ugly piece of metal";
    }

    public override string ToString()
    {
        return base.ToString() + "The weapon has the ability to deal " + damage + " damage to your enemy trolls. " + displayname + " " + ShinyToString(); 
    }
}
