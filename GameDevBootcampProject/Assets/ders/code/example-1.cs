using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class example : MonoBehaviour
{
    string benimadým = "yiðit yýldýrým";
    int yaþým = 18;
    string cinsiyetim = "erkek";
    string adresim = "Mustafa Kemal mah. 694/23sok. Ýzmir Efeler Yurdu izmir/Buca";
    int kilom = 80;
    float boyum = 1.82f;
    int sayi = 0;
    

    void Start()
    {
        Debug.Log( benimadým );
        Debug.Log(yaþým);
        Debug.Log(cinsiyetim);
        Debug.Log(adresim);
        Debug.Log(kilom);

        for (int sayi = 0; sayi <= 100; sayi++)
        {
            Debug.Log("benim sayým :" + sayi);
        }

        for (int sayi = 0; sayi <= 100; sayi+=2)
        {
            Debug.Log("benim çift sayým :" + sayi);
        }
        for (int sayi = 1; sayi <= 100; sayi += 2)
        {
            Debug.Log("benim tek sayým :" + sayi);
        }
    }

   
}
