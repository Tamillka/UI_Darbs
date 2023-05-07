using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ApgerbuParadisana : MonoBehaviour {
    public GameObject mainigaisAttels1;
    public GameObject mainigaisAttels2;
    public GameObject mainigaisAttels3;
    public GameObject mainigaisAttels4;
    public GameObject mainigaisAttels5;
    public GameObject mainigaisAttels6;
    public GameObject mainigaisAttels7;

    public Sprite[] kleitasMasivs;
    public Sprite[] krekliMasivs;
    public Sprite[] svarkiMasivs;
    public Sprite[] kostimiMasivs;
    public Sprite[] apaviMasivs;
    public Sprite[] biksesMasivs;
    public Sprite[] jakasMasivs;
    public void izkritosaisKleitas(int skaitlis) { 
        if (skaitlis == 0)
            mainigaisAttels1.GetComponent<Image>().sprite = kleitasMasivs[0];
        else if (skaitlis == 1)
            mainigaisAttels1.GetComponent<Image>().sprite = kleitasMasivs[1];
        else if (skaitlis == 2)
            mainigaisAttels1.GetComponent<Image>().sprite = kleitasMasivs[2];
        else
            Debug.Log("Nav piesaistīts attēls!");
    }
    public void izkritosaisKrekli(int skaitlis)
    {
        if (skaitlis == 0)
            mainigaisAttels2.GetComponent<Image>().sprite = krekliMasivs[0];
        else if (skaitlis == 1)
            mainigaisAttels2.GetComponent<Image>().sprite = krekliMasivs[1];
        else if (skaitlis == 2)
            mainigaisAttels2.GetComponent<Image>().sprite = krekliMasivs[2];
        else
            Debug.Log("Nav piesaistīts attēls!");
    }
    public void izkritosaisSvarki(int skaitlis)
    {
        if (skaitlis == 0)
            mainigaisAttels3.GetComponent<Image>().sprite = svarkiMasivs[0];
        else if (skaitlis == 1)
            mainigaisAttels3.GetComponent<Image>().sprite = svarkiMasivs[1];
        else if (skaitlis == 2)
            mainigaisAttels3.GetComponent<Image>().sprite = svarkiMasivs[2];
        else
            Debug.Log("Nav piesaistīts attēls!");
    }
    public void izkritosaisKostimi(int skaitlis)
    {
        if (skaitlis == 0)
            mainigaisAttels4.GetComponent<Image>().sprite = kostimiMasivs[0];
        else if (skaitlis == 1)
            mainigaisAttels4.GetComponent<Image>().sprite = kostimiMasivs[1];
        else if (skaitlis == 2)
            mainigaisAttels4.GetComponent<Image>().sprite = kostimiMasivs[2];
        else
            Debug.Log("Nav piesaistīts attēls!");
    }
    public void izkritosaisApavi(int skaitlis)
    {
        if (skaitlis == 0)
            mainigaisAttels5.GetComponent<Image>().sprite = apaviMasivs[0];
        else if (skaitlis == 1)
            mainigaisAttels5.GetComponent<Image>().sprite = apaviMasivs[1];
        else if (skaitlis == 2)
            mainigaisAttels5.GetComponent<Image>().sprite = apaviMasivs[2];
        else
            Debug.Log("Nav piesaistīts attēls!");
    }
    public void izkritosaisBikses(int skaitlis)
    {
        if (skaitlis == 0)
            mainigaisAttels6.GetComponent<Image>().sprite = biksesMasivs[0];
        else if (skaitlis == 1)
            mainigaisAttels6.GetComponent<Image>().sprite = biksesMasivs[1];
        else if (skaitlis == 2)
            mainigaisAttels6.GetComponent<Image>().sprite = biksesMasivs[2];
        else
            Debug.Log("Nav piesaistīts attēls!");
    }
    public void izkritosaisJakas(int skaitlis)
    {
        if (skaitlis == 0)
            mainigaisAttels7.GetComponent<Image>().sprite = jakasMasivs[0];
        else if (skaitlis == 1)
            mainigaisAttels7.GetComponent<Image>().sprite = jakasMasivs[1];
        else 
            Debug.Log("Nav piesaistīts attēls!");
    }


}
