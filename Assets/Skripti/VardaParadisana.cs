using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VardaParadisana : MonoBehaviour
{

    public string teksts;
    public int str;
    public GameObject ievadesLauksVards;
    public GameObject ievadesLauksVecums;
    public GameObject tekstaAttelosana;

    public void UzglabaTekstu()
    {
        teksts = ievadesLauksVards.GetComponent<InputField>().text;
        str = int.Parse(ievadesLauksVecums.GetComponent<InputField>().text);
        tekstaAttelosana.GetComponent<Text>().text = "Cilveka vards ir " + teksts.ToUpper() + ";  vecums: " + str;
    }

}