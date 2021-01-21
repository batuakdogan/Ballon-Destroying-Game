using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyunKontrolcu : MonoBehaviour
{
    public UnityEngine.UI.Text zamanText, balonText;
    public GameObject patlama;
    public float zamanSayaci = 60f;
    int patlayanBalon = 0;
    void Start()
    {
        balonText.text = "Balon : " + patlayanBalon;
    }

    void Update()
    {
        if (zamanSayaci>0)
        {
            zamanSayaci -= Time.deltaTime;
            zamanText.text = "Süre : " + (int)zamanSayaci;
        }
        else
        {
            GameObject[] go = GameObject.FindGameObjectsWithTag("balon");
            for (int i = 0; i < go.Length; i++)
            {
                Instantiate(patlama, go[i].transform.position, go[i].transform.rotation);
                Destroy(go[i]);
            }
        }
        
    }

    public void BalonEkle()
    {
        patlayanBalon += 1;
        balonText.text = "Balon :" + patlayanBalon;


    }
}
