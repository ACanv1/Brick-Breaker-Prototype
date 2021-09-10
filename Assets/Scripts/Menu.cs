using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    GameObject tolevel2;
    public UnityEngine.UI.Button OyundanCikBTN;
    public void DigerSahne()
    {
        SceneManager.LoadScene("Level1");
        

    }
    public void DigerSahne2()
    {
       
        SceneManager.LoadScene("OyunuKazandin");
    }
    public void DigerSahne3()
    {

        SceneManager.LoadScene("OyunuKaybettin");
    }
    public void OyundanCik()
    {
        Debug.Log("Cıktın");
        Application.Quit();
    }

}
