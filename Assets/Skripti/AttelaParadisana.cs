using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttelaParadisana : MonoBehaviour {
    public GameObject kleitas;
    public GameObject kleita;
    public GameObject krekli;
    public GameObject krekls;
    public GameObject svarki;
    public GameObject svarks;
    public GameObject kostimi;
    public GameObject kostims;
    public GameObject apavi;
    public GameObject apavs;
    //public GameObject kleitasMainitPlatumu;
    //public GameObject kleitasMainitAugstumu;

    public void kleitasPar(bool vertiba) { 
        kleitas.SetActive(vertiba);
        kleita.SetActive(vertiba);
        // kleitasMainitAugstumu.SetActive(vertiba);
        // kleitasMainitPlatumu.SetActive(vertiba);
    }
    public void krekliPar(bool vertiba) { 
        krekli.SetActive(vertiba);
        krekls.SetActive(vertiba); 
    }
    public void svarkiPar(bool vertiba)  {
        svarki.SetActive(vertiba);
        svarks.SetActive(vertiba);
    }
    public void kostimiPar(bool vertiba)
    {
        kostimi.SetActive(vertiba);
        kostims.SetActive(vertiba);
    }
    public void apaviPar(bool vertiba)
    {
        apavi.SetActive(vertiba);
        apavs.SetActive(vertiba);
    }

}
