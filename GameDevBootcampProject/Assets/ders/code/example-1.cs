using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Unity.VisualScripting;
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
    int fakt�riyel = 1;
    int say� = 1;
    int toplam = 0; 

    

    void Start()
    {
        Debug.Log( benimad�m );
        Debug.Log(ya��m);
        Debug.Log(cinsiyetim);
        Debug.Log(adresim);
        Debug.Log(kilom);

        for (int sayi = 0; sayi <= 100; sayi++)
        {
            Debug.Log(sayi);
        }

        for (int sayi = 0; sayi <= 100; sayi++)
        {

            Debug.Log(toplam = toplam + sayi );
        }


        for (int sayi = 0; sayi <= 100; sayi+=2)
        {
            Debug.Log(" �ift say�lar :" + sayi);
        }
       
       
        for (int sayi = 1; sayi <= 100; sayi += 2)
        {
            Debug.Log(" tek say�lar :" + sayi);
        }
        
        
        for ( int say� = 1; say� <= 7; say�++)
        {
            fakt�riyel = fakt�riyel*say�;
            Debug.Log(fakt�riyel);
        }
       
        
    }

   
}
