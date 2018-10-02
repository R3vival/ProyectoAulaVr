using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Place")]
public class Place : ScriptableObject {

    public string Nombre="Nombre del lugar";
    public int Bloque;
    public Place padre;

    public GameObject Model;


	
}
