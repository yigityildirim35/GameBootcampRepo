using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class firstLessonCode : MonoBehaviour
{
    // 4!  => 4*3*2*1

    // 10! => 10*9*8*7*6*5*4*3*2*1

    // deðiþkenler

    // cümle,paragraf,isim,özel ad...        => string 
    // 1,2,3,78,87465... sayý rakam          => int  
    // küsüratlý sayý, ondalýklý sayý        => float, double 
    // tek karaktereler, alfabe              => char 
    // iki seçenekli durumlar / doðru-yanlýþ => bool



    string bemimadim = "yiðit";
    string üniversitem = "deu";
   
    char cinsiyetim = 'e';
   
    int yaþým = 18;

    float kilom = 80.8f;

    bool soru = false;

    // eðer 10-20 arasýnda yaþýn varsa çocuksun 
    // eðer 20-30 arasýna yaþýn varsa gençsin 
    // eðer 30-40 arasýnda yaþýn varsa yaþlandýn 

    // mantýksal öperatörler 
    // <
    // >
    // =
    // >=
    // <=
    // !
    // !=


    // karar öperatörtleri
    // ve ==> &&
    // veya ==> ||
    private void Start()
    {
        if (yaþým < 20 && yaþým > 10)
        {
            Debug.Log("çocuksun");
        }
        if (yaþým > 20 && yaþým < 30)
        {
            Debug.Log("gençsin");
        }
        
    }

    // ödev -1 
    /* 
     * isim soyisim yaþ cinsiyet adres boy kilo bilgilerini ekrana yazdýrýn
     * boy kilo endeksini yaptýrýn 
     * 1-100 arasýndaki bütün sayýlarý ekrana yazdýrýn  ===> + - * / 
     * 1-100'e kadar olan sayýlarýn toplamýný yazdýrýn ===> döngü yapýsý 
     * 1-100 arasýndaký sayýlarý cýft olanlarý ekrana yazdýrýn ===> %
     * 1-100 arasýndaký sayýlarý tek olanlarý ekrana yazdýrýn  ===> %
     * 
     * 7! sonucunu yazdýrýn 
     */







}
