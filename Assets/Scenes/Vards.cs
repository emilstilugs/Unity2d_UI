using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Vards : MonoBehaviour
{
    //Mainīgajā saglabās tekstu, ko raksta teksta laukā
    public string teksts;
    //Lauks kurā ieraksta tekstu
    public GameObject ievadesLauks;
    //Kur attēlot tekstu
    public GameObject tekstaAttelosana;

    //Funkcija tiek izsaukta nospiezot pogu
    public void uzglabatTekstu()
    {
        teksts = ievadesLauks.GetComponent<Text>().text;
        tekstaAttelosana.GetComponent<Text>().text = "Sveiks " + teksts.ToUpper() + " !";
    }
}
