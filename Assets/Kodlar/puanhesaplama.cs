using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class puanhesaplama : MonoBehaviour
{
    public Rigidbody rb;
    public Text puantext;

    public GameObject kure,oyun_bitti_pnl;
    static int puan = 0;

    public GameObject[] kalpler;
    int can=3, maxCan=3;
    //public int health=100;
    //float maxHealth = 100f;
    //public Slider healthSlider;
    private void Start()
    {
        rb=GetComponent<Rigidbody>();
        rb.drag = 1;  //kürenin kütlesini 1 olarak başlattık
       // healthSlider.value = maxHealth;
        
    }
    public void canAzalt()
    {
        can--;  //canSistemi fonksiyonundan önce canı bir azaltır. //bunun çalışması tetiklemeye bağlı olarak gerçekleşir.
        canSistemi();
        if (can<=0)   //can değerini kontrol eder eğer can 0 olursa oyun bitti paneli açılır ve oyun durur.
        {
            oyun_bitti_pnl.SetActive(true);
            Time.timeScale = 0f;
            puan = 0; //can sıfır olduğunda puanıda sıfırlıyoruz ki yeniden başladığımızda puan kaldığı yerden devam etmesin
        }
        //PlayerPrefs.SetInt("can", can);
    }
    void canSistemi()
    {
        for (int i = 0; i < maxCan; i++)  
        {
            kalpler[i].SetActive(false);  
        }
        for (int i = 0; i < can; i++)
        {
            kalpler[i].SetActive(true);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.name=="zemin")
        {
            puan++;
            puantext.text = puan.ToString();
            
        }
        if (collision.gameObject.name=="zemin2")
        {
            rb.drag = rb.drag - 0.5f; //eğer küre zemin2 ye çarparsa kürenin kütlesini azalt ve daha hızlı düşmesini sağla.
            canAzalt();  //can azalt fonksiyonu çalışır. Her zemin2 ye çarptığında can 1 azalır.
            puan--;
            if (puan == -1)  
            {
                puan = 0;
            }
            puantext.text = puan.ToString();
        }

        PlayerPrefs.SetInt("puan", puan);  
        PlayerPrefs.SetInt("puan2", puan);
        PlayerPrefs.SetInt("puan3", puan);

        if (puan > 9)  //puan 10 olursa oyun bitti paneli açılır ve oyun durur.
        {
            oyun_bitti_pnl.SetActive(true);
            Time.timeScale = 0f;

            puan = 0;
        }
    }
}
