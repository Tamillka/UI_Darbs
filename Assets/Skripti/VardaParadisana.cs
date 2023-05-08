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
    public GameObject tekstaAttelosana2;

    public void UzglabaTekstu()
    {
        teksts = ievadesLauksVards.GetComponent<InputField>().text;
        str = int.Parse(ievadesLauksVecums.GetComponent<InputField>().text);
        tekstaAttelosana.GetComponent<Text>().text = "Sī varoņa vārds ir " + teksts.ToUpper() + " un viņa vecums ir " + str + ". \nReiz viņa bija nāra, " +
            "bet viņa ieradās uz zemi, lai kļūtu par jūsu galveno palīgu dzīvē. Viņa ir nemirstīga un spēs dot jums vairākas dzīvības vai izārstēt jūs no jebkuras slimības. " +
            "Protams, kādreiz tev būs iespēja viņu pabarot, bet šobrīd viņai nekas cits kā ērts tērps nav vajadzīgs.";
         
            
    }
    public void UzglabaTekstu2()
    {
        teksts = ievadesLauksVards.GetComponent<InputField>().text;
        str = int.Parse(ievadesLauksVecums.GetComponent<InputField>().text);
        tekstaAttelosana2.GetComponent<Text>().text = "Sī varoņa vārds ir " + teksts.ToUpper() + " un viņa vecums ir " + str + ". \nSim varonim piemit superspeja - vina dzivnieki, kuri sarga dzivibu un jut visu tapat ka cilveks, attiecigi raksturs ir 2x specigaks.";
    }


}