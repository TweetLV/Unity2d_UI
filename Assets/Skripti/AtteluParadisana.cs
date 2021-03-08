using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtteluParadisana : MonoBehaviour{
    //Uzglabās mūsu bildes no ainas
    public GameObject bins;
    public GameObject lacitis;
    public GameObject tante;
    public GameObject masina;

    public void binaAttelosana(bool vertiba)
    {
        bins.SetActive(vertiba);
    }
    public void lacitisAttelosana(bool vertiba)
    {
        lacitis.SetActive(vertiba);
    }
    public void tanteAttelosana(bool vertiba)
    {
        tante.SetActive(vertiba);
    }
    public void masinaAttelosana(bool vertiba)
    {
        masina.SetActive(vertiba);
    }
    public void paKreisiBins(bool vertiba)
    {
        bins.transform.localScale = new Vector2(1,1);
    }
    public void paLabiBins(bool vertiba)
    {
        bins.transform.localScale = new Vector2(-1, 1);
    }
}
