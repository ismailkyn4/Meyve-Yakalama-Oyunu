using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Çarpışma : MonoBehaviour
{
    public GameObject zemin,zemin2;
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name=="kure") 
        {
            gameObject.SetActive(false);
        }
        int xPosition = Random.Range(-5, 5); //kurenin x pozisyonunu herhangi iki nokta arasında yeniden oluşturması için range ettik.
        gameObject.transform.position = new Vector3(xPosition, 4.0f, 0f); //sonrasında kurenin yeni kordinatını belirledik.
                                                                    //x pozisyonu rastgele değer alıcak.
                                                                    //y ve z pozisyonu hep sabit olduğu için değişmedi.
        //int puanyeni = PlayerPrefs.GetInt("puan");  //puan değerini puanyeni değerinin içine get ettik.
        //if (puanyeni < 0)
        //{
        //    Destroy(kure);
        //    text.SetActive(true);    //oyun bitti textini true yaptık.
        //}
    }

}
