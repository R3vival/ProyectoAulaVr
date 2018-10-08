using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FillContent : MonoBehaviour {

    public PlaceList placeList;
    


    private void Start()
    {
        InstantiatePlace();           
    }

    public void InstantiatePlace()
    {
        GameObject y = null;
        foreach (Place x in placeList.placesList)
        {
            if (x.ppal)
            {
                y = Instantiate(x.Model, transform.position, transform.rotation) as GameObject;
                y.transform.SetParent(transform);
                y.transform.localScale = new Vector3(1, 1, 1);
                SetDefaultValues(y, x);
            }

        }
    }

    public void SetDefaultValues(GameObject placeGO, Place place)
    {
        placeGO.gameObject.transform.Find("Text").GetComponent<Text>().text = place.name;
    }

    public void SetContentCellSize()
    {        
        //transform.GetComponentInParent<CanvasScaler>();
    }
}
