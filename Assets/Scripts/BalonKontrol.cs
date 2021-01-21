using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalonKontrol : MonoBehaviour
{
    public GameObject patlama;
    OyunKontrolcu oyunKontrolScripti;


    private void Start()
    {
        oyunKontrolScripti = GameObject.Find("_Scripts").GetComponent<OyunKontrolcu>();
    }

    private void OnMouseDown()
    {

    GameObject go  =    Instantiate(patlama, transform.position, transform.rotation)  as GameObject  ;

        Destroy(this.gameObject);
        Destroy(go, 0.583f);
        oyunKontrolScripti.BalonEkle();

    }
}
