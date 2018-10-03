using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class armour : Activatable
{
    public float protection;
    public bool isFierce;

    public override string activateText()
    {
        return "You equipped " + displayname + ".";
    }

    public override string deactivateText()
    {
        return "You unequipped " + displayname + ".";
    }

    public string ShinyToString()
    {
        if (isFierce)
            return " is so fierce that Trump hires you as his bodyguard";
        else
            return " makes you look like a noob. You have no friends";
    }

    public override string ToString()
    {
        return base.ToString() + "\n" + displayname + " has a protection of " + protection + " and " + ShinyToString();
    }
}