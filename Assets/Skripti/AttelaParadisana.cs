using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttelaParadisana : MonoBehaviour {
    public GameObject kleitas;
    public GameObject kleita;
    //public GameObject kleitasMainitPlatumu;
    //public GameObject kleitasMainitAugstumu;

    public void kleitasPar(bool vertiba) { 
        kleitas.SetActive(vertiba);
        kleita.SetActive(vertiba);
        // kleitasMainitAugstumu.SetActive(vertiba);
        // kleitasMainitPlatumu.SetActive(vertiba);
    }

}
