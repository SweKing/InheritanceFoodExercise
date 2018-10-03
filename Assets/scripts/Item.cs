using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{

    public string displayname;
    public float weight;
    public float cost;

    public float GetPricePerWeight()
    {
        return cost / weight;
    }

    public override string ToString()
    {
        return "this is " + displayname + ". It weighs " + weight + " kittens and its total price is " + cost +
            " pretty-pretty coins. The price per kitten is therefore " + GetPricePerWeight() + " pretty-pretty coins. ";
    }

    public virtual void OnMouseEnter()
    {
        Debug.Log(ToString());
    }
}
