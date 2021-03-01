using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Jaieimporte, lai varetu stradat ar UI elementiem
using UnityEngine.UI;


public class VardaParadisana : MonoBehaviour{
    //Mainīgajā saglabās tekstu ko raksta teksta laukā
    public string teksts;
    //Lauks, kurā ieraksta tekstu
    public GameObject ievadesLauks;
    //Kur attelot tekstu
    public GameObject tekstaAttelosana;

    //Funkcija tiek izsaukta nospiežot pogu
    public void uzglabatTekstu(){
        teksts = ievadesLauks.GetComponent<Text>().text;
        tekstaAttelosana.GetComponent<Text>().text = "Sveiks " + teksts.ToUpper() + "!";
            ;
    }

}
