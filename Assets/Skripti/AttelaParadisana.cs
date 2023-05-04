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
    public GameObject korona;
    public GameObject palochka;
    public GameObject wings;
    public GameObject aSlaiderisK;
    public GameObject pSlaiderisK;
    public GameObject aSlaiderisKr;
    public GameObject pSlaiderisKr;
    public GameObject aSlaiderisS;
    public GameObject pSlaiderisS;
    public GameObject aSlaiderisKo;
    public GameObject pSlaiderisKo;
    public GameObject aSlaiderisA;
    public GameObject pSlaiderisA;
    public GameObject slaiderisK;
    public GameObject slaiderisP;
    public GameObject slaiderisW;



    public void kleitasPar(bool vertiba) { 
        kleitas.SetActive(vertiba);
        kleita.SetActive(vertiba);
        aSlaiderisK.SetActive(vertiba);
        pSlaiderisK.SetActive(vertiba);
    }
    public void mainitPlatumuK()
    {
        float pasreizejaVertiba = pSlaiderisK.GetComponent<Slider>().value;
        float platums = kleita.transform.localScale.y;
        Vector2 newScale = new Vector2(1f * pasreizejaVertiba, platums);
        kleita.transform.localScale = newScale;
    }
    public void mainitAugstumuK()
    {
        float pasreizejaVertiba = aSlaiderisK.GetComponent<Slider>().value;
        float augstums = kleita.transform.localScale.x;
        Vector2 newScale = new Vector2(augstums, 1f * pasreizejaVertiba);
        kleita.transform.localScale = newScale;
    }
    public void krekliPar(bool vertiba) { 
        krekli.SetActive(vertiba);
        krekls.SetActive(vertiba);
        aSlaiderisKr.SetActive(vertiba);
        pSlaiderisKr.SetActive(vertiba);
    }
    public void mainitPlatumuKr()
    {
        float pasreizejaVertiba = pSlaiderisKr.GetComponent<Slider>().value;
        float platums = krekls.transform.localScale.y;
        Vector2 newScale = new Vector2(1f * pasreizejaVertiba, platums);
        krekls.transform.localScale = newScale;
    }
    public void mainitAugstumuKr()
    {
        float pasreizejaVertiba = aSlaiderisKr.GetComponent<Slider>().value;
        float augstums = krekls.transform.localScale.x;
        Vector2 newScale = new Vector2(augstums, 1f * pasreizejaVertiba);
        krekls.transform.localScale = newScale;
    }
    public void svarkiPar(bool vertiba)  {
        svarki.SetActive(vertiba);
        svarks.SetActive(vertiba);
        aSlaiderisS.SetActive(vertiba);
        pSlaiderisS.SetActive(vertiba);
    
}
    public void mainitPlatumuS()
    {
        float pasreizejaVertiba = pSlaiderisS.GetComponent<Slider>().value;
        float platums = svarks.transform.localScale.y;
        Vector2 newScale = new Vector2(1f * pasreizejaVertiba, platums);
        svarks.transform.localScale = newScale;
    }
    public void mainitAugstumuS()
    {
        float pasreizejaVertiba = aSlaiderisS.GetComponent<Slider>().value;
        float augstums = svarks.transform.localScale.x;
        Vector2 newScale = new Vector2(augstums, 1f * pasreizejaVertiba);
        svarks.transform.localScale = newScale;
    }
    public void kostimiPar(bool vertiba)
    {
        kostimi.SetActive(vertiba);
        kostims.SetActive(vertiba);
        aSlaiderisKo.SetActive(vertiba);
        pSlaiderisKo.SetActive(vertiba);
    
}
    public void mainitPlatumuKo()
    {
        float pasreizejaVertiba = pSlaiderisKo.GetComponent<Slider>().value;
        float platums = kostims.transform.localScale.y;
        Vector2 newScale = new Vector2(1f * pasreizejaVertiba, platums);
        kostims.transform.localScale = newScale;
    }
    public void mainitAugstumuKo()
    {
        float pasreizejaVertiba = aSlaiderisKo.GetComponent<Slider>().value;
        float augstums = kostims.transform.localScale.x;
        Vector2 newScale = new Vector2(augstums, 1f * pasreizejaVertiba);
        kostims.transform.localScale = newScale;
    }
    public void apaviPar(bool vertiba)
    {
        apavi.SetActive(vertiba);
        apavs.SetActive(vertiba);
        aSlaiderisA.SetActive(vertiba);
        pSlaiderisA.SetActive(vertiba);
    
}
    public void mainitPlatumuA()
    {
        float pasreizejaVertiba = pSlaiderisA.GetComponent<Slider>().value;
        float platums = apavs.transform.localScale.y;
        Vector2 newScale = new Vector2(1f * pasreizejaVertiba, platums);
        apavs.transform.localScale = newScale;
    }
    public void mainitAugstumuA()
    {
        float pasreizejaVertiba = aSlaiderisA.GetComponent<Slider>().value;
        float augstums = apavs.transform.localScale.x;
        Vector2 newScale = new Vector2(augstums, 1f * pasreizejaVertiba);
        apavs.transform.localScale = newScale;
    }
    public void aksesuariPar(bool vertiba){
        korona.SetActive(vertiba);
        palochka.SetActive(vertiba);
        wings.SetActive(vertiba);
        slaiderisK.SetActive(vertiba);
        slaiderisP.SetActive(vertiba);
        slaiderisW.SetActive(vertiba);
    }
    public void mainitLielumuK()
    {
        float pasreizejaVartiba = slaiderisK.GetComponent<Slider>().value;
        korona.transform.localScale = new Vector2(1f * pasreizejaVartiba, 1f * pasreizejaVartiba);
    }
    public void mainitLielumuP()
    {
        float pasreizejaVartiba = slaiderisP.GetComponent<Slider>().value;
        palochka.transform.localScale = new Vector2(1f * pasreizejaVartiba, 1f * pasreizejaVartiba);
    }
    public void mainitLielumuW()
    {
        float pasreizejaVartiba = slaiderisW.GetComponent<Slider>().value;
        wings.transform.localScale = new Vector2(1f * pasreizejaVartiba, 1f * pasreizejaVartiba);
    }
}
