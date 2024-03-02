using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button : MonoBehaviour
{
   public void anaoyun()
   {
        SceneManager.LoadScene("anaoyun");
   }
    public void girisekrani()
    {
        SceneManager.LoadScene("girisekrani");
    }
    public void lvliki()
    {
        SceneManager.LoadScene("oyunlvl2");
    }
}
