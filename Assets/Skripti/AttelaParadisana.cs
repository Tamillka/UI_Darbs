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
    public GameObject bikses;
    public GameObject bikse;
    public GameObject jakas;
    public GameObject jaka;
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
    public GameObject slaideris1;
    public GameObject slaideris2;
    public GameObject slaideris3;
    public GameObject pSlaiderisB;
    public GameObject aSlaiderisB;
    public GameObject pSlaiderisJ;
    public GameObject aSlaiderisJ;
    public GameObject suns;
    public GameObject bird;
    public GameObject dino;


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
        slaideris1.SetActive(vertiba);
        slaideris2.SetActive(vertiba);
        slaideris3.SetActive(vertiba);
    }
    public void mainitLielumuK()
    {
        float pasreizejaVartiba = slaideris1.GetComponent<Slider>().value;
        korona.transform.localScale = new Vector2(1f * pasreizejaVartiba, 1f * pasreizejaVartiba);
    }
    public void mainitLielumuP()
    {
        float pasreizejaVartiba = slaideris2.GetComponent<Slider>().value;
        palochka.transform.localScale = new Vector2(1f * pasreizejaVartiba, 1f * pasreizejaVartiba);
    }
    public void mainitLielumuW()
    {
        float pasreizejaVartiba = slaideris3.GetComponent<Slider>().value;
        wings.transform.localScale = new Vector2(1f * pasreizejaVartiba, 1f * pasreizejaVartiba);
    }
    public void biksesPar(bool vertiba)
    {
        bikses.SetActive(vertiba);
        bikse.SetActive(vertiba);
        aSlaiderisB.SetActive(vertiba);
        pSlaiderisB.SetActive(vertiba);

    }
    public void mainitPlatumuB()
    {
        float pasreizejaVertiba = pSlaiderisB.GetComponent<Slider>().value;
        float platums = bikse.transform.localScale.y;
        Vector2 newScale = new Vector2(1f * pasreizejaVertiba, platums);
        bikse.transform.localScale = newScale;
    }
    public void mainitAugstumuB()
    {
        float pasreizejaVertiba = aSlaiderisB.GetComponent<Slider>().value;
        float augstums = bikse.transform.localScale.x;
        Vector2 newScale = new Vector2(augstums, 1f * pasreizejaVertiba);
        bikse.transform.localScale = newScale;
    }
    public void jakasPar(bool vertiba)
    {
        jakas.SetActive(vertiba);
        jaka.SetActive(vertiba);
        aSlaiderisJ.SetActive(vertiba);
        pSlaiderisJ.SetActive(vertiba);

    }
    public void mainitPlatumuJ()
    {
        float pasreizejaVertiba = pSlaiderisJ.GetComponent<Slider>().value;
        float platums = jaka.transform.localScale.y;
        Vector2 newScale = new Vector2(1f * pasreizejaVertiba, platums);
        jaka.transform.localScale = newScale;
    }
    public void mainitAugstumuJ()
    {
        float pasreizejaVertiba = aSlaiderisJ.GetComponent<Slider>().value;
        float augstums = jaka.transform.localScale.x;
        Vector2 newScale = new Vector2(augstums, 1f * pasreizejaVertiba);
        jaka.transform.localScale = newScale;
    }
    public void dzivniekiPar(bool vertiba)
    {
        suns.SetActive(vertiba);
        bird.SetActive(vertiba);
        dino.SetActive(vertiba);
        slaideris1.SetActive(vertiba);
        slaideris2.SetActive(vertiba);
        slaideris3.SetActive(vertiba);
    }

    public void mainitLielumuSu()
    {
        float pasreizejaVartiba = slaideris1.GetComponent<Slider>().value;
        suns.transform.localScale = new Vector2(1f * pasreizejaVartiba, 1f * pasreizejaVartiba);
    }
    public void mainitLielumuBi()
    {
        float pasreizejaVartiba = slaideris2.GetComponent<Slider>().value;
        bird.transform.localScale = new Vector2(1f * pasreizejaVartiba, 1f * pasreizejaVartiba);
    }
    public void mainitLielumuD()
    {
        float pasreizejaVartiba = slaideris3.GetComponent<Slider>().value;
        dino.transform.localScale = new Vector2(1f * pasreizejaVartiba, 1f * pasreizejaVartiba);
    }
}
