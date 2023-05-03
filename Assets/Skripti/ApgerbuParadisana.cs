using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ApgerbuParadisana : MonoBehaviour {
    public GameObject mainigaisAttels1;
   // public GameObject izmSlaideris11;
    //public GameObject izmSlaideris21;
    public Sprite[] atteluMasivs1;

    public void izkritosaisKleitas(int skaitlis) { 
        if (skaitlis == 0)
            mainigaisAttels1.GetComponent<Image>().sprite = atteluMasivs1[0];
        else if (skaitlis == 1)
            mainigaisAttels1.GetComponent<Image>().sprite = atteluMasivs1[1];
        else if (skaitlis == 2)
            mainigaisAttels1.GetComponent<Image>().sprite = atteluMasivs1[2];
        else
            Debug.Log("Nav piesaistīts attēls!");
    }

}
