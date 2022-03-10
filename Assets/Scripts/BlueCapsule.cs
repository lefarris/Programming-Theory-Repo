using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueCapsule : Capsule // INHERITANCE
{
    public override void SetColor() // POLYMORPHISM
    {
        Debug.Log("Set Color to: Black");
        material.color = Color.blue;
    }
}
