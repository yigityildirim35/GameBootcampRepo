using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class example : MonoBehaviour
{
    string benimad�m = "yi�it y�ld�r�m";
    int ya��m = 18;
    string cinsiyetim = "erkek";
    string adresim = "Mustafa Kemal mah. 694/23sok. �zmir Efeler Yurdu izmir/Buca";
    int kilom = 80;
    float boyum = 1.82f;
    int sayi = 0;
    

    void Start()
    {
        Debug.Log( benimad�m );
        Debug.Log(ya��m);
        Debug.Log(cinsiyetim);
        Debug.Log(adresim);
        Debug.Log(kilom);

        for (int sayi = 0; sayi <= 100; sayi++)
        {
            Debug.Log("benim say�m :" + sayi);
        }

        for (int sayi = 0; sayi <= 100; sayi+=2)
        {
            Debug.Log("benim �ift say�m :" + sayi);
        }
        for (int sayi = 1; sayi <= 100; sayi += 2)
        {
            Debug.Log("benim tek say�m :" + sayi);
        }
    }

   
}
