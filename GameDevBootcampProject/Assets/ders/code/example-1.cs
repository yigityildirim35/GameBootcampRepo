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
    int boyum = 182;
    int sayi = 0;
    int fakt�riyel = 1;
    int say� = 1;
    int toplam = 0;
    string vki = "beden endeksim";
     

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

        float vki = kilom / (boyum * boyum);
         
         
        if (vki < 18.5 && vki > 24.9)
        {
            Debug.Log("zay�fs�n");
        }
        if (vki < 24.9 && vki > 25)
        {
            Debug.Log("normal kilodas�n");
        }
        if ( vki < 25)
        {
            Debug.Log("kilolusun");
        }
    }


   
}
