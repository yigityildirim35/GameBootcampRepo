using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class firstLessonCode : MonoBehaviour
{
    // 4!  => 4*3*2*1

    // 10! => 10*9*8*7*6*5*4*3*2*1

    // de�i�kenler

    // c�mle,paragraf,isim,�zel ad...        => string 
    // 1,2,3,78,87465... say� rakam          => int  
    // k�s�ratl� say�, ondal�kl� say�        => float, double 
    // tek karaktereler, alfabe              => char 
    // iki se�enekli durumlar / do�ru-yanl�� => bool



    string bemimadim = "yi�it";
    string �niversitem = "deu";
   
    char cinsiyetim = 'e';
   
    int ya��m = 18;

    float kilom = 80.8f;

    bool soru = false;

    // e�er 10-20 aras�nda ya��n varsa �ocuksun 
    // e�er 20-30 aras�na ya��n varsa gen�sin 
    // e�er 30-40 aras�nda ya��n varsa ya�land�n 

    // mant�ksal �perat�rler 
    // <
    // >
    // =
    // >=
    // <=
    // !
    // !=


    // karar �perat�rtleri
    // ve ==> &&
    // veya ==> ||
    private void Start()
    {
        if (ya��m < 20 && ya��m > 10)
        {
            Debug.Log("�ocuksun");
        }
        if (ya��m > 20 && ya��m < 30)
        {
            Debug.Log("gen�sin");
        }
        
    }

    // �dev -1 
    /* 
     * isim soyisim ya� cinsiyet adres boy kilo bilgilerini ekrana yazd�r�n
     * boy kilo endeksini yapt�r�n 
     * 1-100 aras�ndaki b�t�n say�lar� ekrana yazd�r�n  ===> + - * / 
     * 1-100'e kadar olan say�lar�n toplam�n� yazd�r�n ===> d�ng� yap�s� 
     * 1-100 aras�ndak� say�lar� c�ft olanlar� ekrana yazd�r�n ===> %
     * 1-100 aras�ndak� say�lar� tek olanlar� ekrana yazd�r�n  ===> %
     * 
     * 7! sonucunu yazd�r�n 
     */







}
