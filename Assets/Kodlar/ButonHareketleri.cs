using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButonHareketleri : MonoBehaviour
{
    int genislik = 7;
    float tekrarlamaMiktari = 1.5f;
    void Start()
    {
    }
    void Update()
    {
        float x = Mathf.Cos(Time.time * tekrarlamaMiktari) * genislik;  //genişlik hangi iki değer arasında hareket edeceğinizi gösterir.
        float z = transform.position.z;
        float y = transform.position.y;
        transform.position = new Vector3(x, y, z);

    }
}
