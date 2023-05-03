using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AtteluParadisana : MonoBehaviour {

    public GameObject mainigaisAttels;
    public GameObject izmSlaideris1;
    public GameObject izmSlaideris2;

    public void mainitPlatumu()
    {
        float pasreizejaVertiba = izmSlaideris1.GetComponent<Slider>().value;
        float augstums = mainigaisAttels.transform.localScale.y;
        Vector2 newScale = new Vector2(1f * pasreizejaVertiba, augstums);
        mainigaisAttels.transform.localScale = newScale;
    }
    public void mainitAugstumu()
    {
        float pasreizejaVertiba = izmSlaideris2.GetComponent<Slider>().value;
        float platums = mainigaisAttels.transform.localScale.x;
        Vector2 newScale = new Vector2(platums, 1f * pasreizejaVertiba);
        mainigaisAttels.transform.localScale = newScale;
    }
}
