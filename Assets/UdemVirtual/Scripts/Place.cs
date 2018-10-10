using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Place")]
public class Place : ScriptableObject {

    public string Nombre = "Nombre del lugar";
    public int Bloque;
    public string SobreNombre = "Nombre que le suelen poner los estudiantes";
    public bool ppal;
    
    public GameObject Model;

    public List<Place> Sons;

    


	
}
