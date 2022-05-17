using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HareketYeni : MonoBehaviour
{
    int hareket_hizi = 3000;
    private float yatayhareket;
    int puan;
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        puan = PlayerPrefs.GetInt("puan");
        if (puan != 10)
        {
           // yatayhareket = Input.GetAxis("Horizontal");
            float xposition = Mathf.Clamp(yatayhareket * hareket_hizi * Time.deltaTime, -3.4f, 3.4f);
            rb.velocity = new Vector2(xposition, rb.velocity.y);
        }
    }
    public void sol()
    {
        yatayhareket = -10;
        //if (yatayhareket<-3.4f)
        //{
        //    yatayhareket = 0;
        //}
    }
    public void sağ()
    {
        yatayhareket = 10;
        //if (yatayhareket > 3.4f)
        //{
        //    yatayhareket = 0;
        //}
    }
    public void dur()
    {
        yatayhareket = 0;
    }
}
