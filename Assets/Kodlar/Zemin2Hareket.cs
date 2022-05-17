using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zemin2Hareket : MonoBehaviour
{
    int puan;
    float xposition;
    void Start()
    {
        
    }
    void Update()
    {
        hareketlenme2();   
    }
    public void hareketlenme2()
    {
        puan = PlayerPrefs.GetInt("puan2");
        if (puan != 10)
        {
            float hiz = 0.15f * Input.GetAxisRaw("Horizontal");
            transform.Translate(hiz, 0f, 0f);
            xposition = Mathf.Clamp(transform.position.x, -3.9f, 3.9f);//değerlerin dışına çıkmaması için
            transform.position = new Vector2(xposition, transform.position.y); //y pozisyonu sabit,x değeri değişir
        }
    }
}
