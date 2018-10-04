using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Place")]
public class Place : ScriptableObject {

    public string Nombre = "Nombre del lugar";
    public bool ppal;
    public int Bloque;
    public GameObject Model;

    public List<Place> Sons;

    


	
}
