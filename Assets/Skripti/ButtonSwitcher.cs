using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonSwitcher : MonoBehaviour
{
    public Dropdown dropdown;
    public GameObject[] buttons;

    void Start()
    {
        dropdown.onValueChanged.AddListener(delegate { SwitchButtons(dropdown); });
        SwitchButtons(dropdown);
    }

    void SwitchButtons(Dropdown dropdown)
    {
        int index = dropdown.value;
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].SetActive(i == index);
        }
    }
}
