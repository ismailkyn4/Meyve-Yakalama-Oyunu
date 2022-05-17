using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SahneGeçişleri : MonoBehaviour
{
    //ZeminHareket zeminHareket = new ZeminHareket();
    //Zemin2Hareket zeminHareket2 = new Zemin2Hareket();
    //ZeminHareket3 zeminHareket3 = new ZeminHareket3();

    public GameObject oyun_bitti_panel,Exit_txt;
    public void playBtn()
    {
        SceneManager.LoadScene(1); //oyun sahnesi1e geçer
    }
    public  void oyunsahnesi1_gec()  
    {
        SceneManager.LoadScene(1); 
        oyun_bitti_panel.SetActive(false);
        Time.timeScale = 1f;
        //zeminHareket.hareketlenme();

    }
    public void Oyun_sonu()
    {
        Application.Quit();
    }
    public void oyunsahnesi2_gec()
    {
        SceneManager.LoadScene(2);
        oyun_bitti_panel.SetActive(false);
        Time.timeScale = 1f;
        //zeminHareket2.hareketlenme2();

    }
    public void oyunsahnesi3_gec()
    {
        SceneManager.LoadScene(3);
        oyun_bitti_panel.SetActive(false);
        Time.timeScale = 1f;
       // zeminHareket3.hareketlenme3();
    }
    public void AnasayfaDon()
    {
        Exit_txt.SetActive(true);
        Time.timeScale = 0f;
    }
    public void yesButon()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1.0f;
    }
    public void noButon()
    {
        Exit_txt.SetActive(false);
        Time.timeScale = 1f;
    }


}
