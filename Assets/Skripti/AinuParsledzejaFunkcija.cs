using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AinuParsledzejaFunkcija : MonoBehaviour
{

    public void uzSakumu()
    {
        SceneManager.LoadScene("Sakums", LoadSceneMode.Single);
    }

    public void apturet()
    {
        Application.Quit();
    }

    public void uzScene()
    {
        SceneManager.LoadScene("Galvena", LoadSceneMode.Single);
    }
}