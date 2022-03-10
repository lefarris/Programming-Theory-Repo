using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : MonoBehaviour
{
    public Material material { get; private set; } // ENCAPSULATION

    private void Start()
    {
        material = GetComponent<Renderer>().material;

        SetColor();
    }

    public virtual void SetColor() // ABSTRACTION
    {
        Debug.Log("Set Color to: Black");
        material.color = Color.black;
    }
}
