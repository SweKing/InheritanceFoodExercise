using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : Usability
{
    public float saturation;
    public bool goodTaste;

    public override void Use()
    {
        base.Use();
    }

    public override string UseText()
    {
        return "You just consumed a piece of " + displayname + ". There are " + uses + " pieces left.";
    }
    
    public override string NoUsesRemainingText()
    {
        return "You felt like eating all of the " + displayname + ". But because you're such a nice person you decided to leave some of it for someone else. You now feel very nice";
    }

    public string TasteToString()
    {
        if (goodTaste)
            return  " tastes good like mama's meatballs";
        else
            return  "is actually too ugly to eat. But you don't care, cause you're a human dustbin";
    }

    public override string ToString()
    {
        return base.ToString() + "The " + displayname + " grants you a saturation of " + saturation +  " and " + TasteToString();
    }
}
