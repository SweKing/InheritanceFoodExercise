using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activatable : Item
{
    public bool isActivated = false;
  
    public void OnMouseUpAsButton()
    {
        if (isActivated == true)
        {
            isActivated = false;
            Debug.Log(deactivateText());
        }
        else if (isActivated == false)
        {
            isActivated = true;
            Debug.Log(activateText());
        }
    }

    public virtual string activateText()
    {
        return "You activated this item";
    }

    public virtual string deactivateText()
    {
        return "You deactivated this item";
    }

    public override string ToString()
    {
        return base.ToString() + "";
    }
}
