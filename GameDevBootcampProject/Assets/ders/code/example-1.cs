using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Unity.VisualScripting;
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
    int faktöriyel = 1;
    int sayý = 1;
    int toplam = 0; 

    

    void Start()
    {
        Debug.Log( benimadým );
        Debug.Log(yaþým);
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
            Debug.Log(" çift sayýlar :" + sayi);
        }
       
       
        for (int sayi = 1; sayi <= 100; sayi += 2)
        {
            Debug.Log(" tek sayýlar :" + sayi);
        }
        
        
        for ( int sayý = 1; sayý <= 7; sayý++)
        {
            faktöriyel = faktöriyel*sayý;
            Debug.Log(faktöriyel);
        }
       
        
    }

   
}
