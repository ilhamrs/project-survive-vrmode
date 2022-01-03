using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{

    public void Merah()
    {
        GetComponent<Renderer>().material.color = Color.red;
    }
    public void Biru()
    {
        GetComponent<Renderer>().material.color = Color.blue;
    }

    public void Hijau()
    {
        GetComponent<Renderer>().material.color = Color.green;
    }
}
