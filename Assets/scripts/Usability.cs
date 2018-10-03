using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Usability : Item
{
    public float uses;
    public float maxUses;

    public void OnMouseUpAsButton()
    {
        if (uses >= 1)
        {
            Debug.Log(UseText());  //baaaaals lmao
            Use();
        }
        else if (uses <= -1)
        {
            Debug.Log(CannotUseAnymore());
        }
        else
        {
            Debug.Log(NoUsesRemainingText());
            Use();
        }
    }

    public virtual void Use()
    {
        uses--;
    }

    public virtual string UseText()
    {
        return "You used one instance of " + displayname + ". It has " + uses + " left.";
    }

    public virtual string CannotUseAnymore()
    {
        return "unable to use";
    }

    public virtual string NoUsesRemainingText()
    {
        return "You've run out of uses on this item";
    }

    public override string ToString()
    {
        return base.ToString() + "It has a total of " + maxUses + " maximal uses before mental breakdown. \n Right now you have a total of " + uses + " left. ";
    }
}
