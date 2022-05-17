using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZeminHareket : MonoBehaviour
{
    int puan;
    float xposition;
    void Start()
    {

    }
    void Update()
    {
        hareketlenme();
    }
    public void hareketlenme()
    {
        puan = PlayerPrefs.GetInt("puan");
        if (puan != 10)
        {
            float hiz = 0.15f * Input.GetAxisRaw("Horizontal");
            transform.Translate(hiz, 0f, 0f);
            xposition = Mathf.Clamp(transform.position.x, -3.4f, 3.4f);//değerlerin dışına çıkmaması için
            transform.position = new Vector2(xposition, transform.position.y); //y pozisyonu sabit,x değeri değişir
        }
        //if (puan > 9)
        //{
        //    enabled = false;
        //    puan = 0;
        //}    
    }


}
