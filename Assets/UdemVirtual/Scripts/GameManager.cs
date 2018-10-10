using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class GameManager : MonoBehaviour {


    #region Variables

    FillContent fillcontentScript;

    List<GameObject> GOPlacesList;

    char[] SearchWord, PlaceWord;

    #endregion

    private void Start()
    {
        if(fillcontentScript==null)
            fillcontentScript = GameObject.Find("Content").gameObject.GetComponent<FillContent>();

        GOPlacesList = fillcontentScript.PlacesList;

        fillcontentScript.InstantiatePlace();
    }

    public void Search(Text text)
    {
        LimpiarResultado();
        var places = fillcontentScript.placeList.placesList
            .Where(
                place =>
                    place.Nombre.ToUpper().Contains(text.text.ToUpper())
                    || place.SobreNombre.ToUpper().Contains(text.text.ToUpper())
                    || place.Bloque.ToString().ToUpper().Contains(text.text.ToUpper())
            );

        foreach(var place in places)
        {
            GOPlacesList.Where(e => e.name == place.name).FirstOrDefault().SetActive(true);
        }
    }

    public void LimpiarResultado()
    {
        foreach (GameObject go in GOPlacesList)
        {
           go.SetActive(false);
        }
    }
}
