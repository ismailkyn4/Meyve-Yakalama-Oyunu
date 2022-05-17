using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZeminHareket3 : MonoBehaviour
{
    int puan;
    float xposition;
    void Start()
    {

    }
    void Update()
    {
        hareketlenme3();
    }
    public void hareketlenme3()
    {
        puan = PlayerPrefs.GetInt("puan3");
        if (puan != 10)
        {
            float hiz = 0.15f * Input.GetAxisRaw("Horizontal");
            transform.Translate(hiz, 0f, 0f);
            xposition = Mathf.Clamp(transform.position.x, -4.7f, 4.7f);//değerlerin dışına çıkmaması için
            transform.position = new Vector2(xposition, transform.position.y); //y pozisyonu sabit,x değeri değişir
        }
    }
}
