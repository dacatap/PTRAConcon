using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using UnityEngine;

public class OpenMap : MonoBehaviour
{
    public int id;
    public void Open(){

        switch(id){
        case 1:
            Application.OpenURL("https://maps.app.goo.gl/Kw4vEkJZmfXhVTdeA");
            break;
        case 2:
            Application.OpenURL("https://maps.app.goo.gl/5q114f9Pabi65npJ7");
            break;
        case 3:
            Application.OpenURL("https://maps.app.goo.gl/V7Uw6f1HA5ZyJFYy6");
            break;
        case 4:
            Application.OpenURL("https://maps.app.goo.gl/EcbeCwrxwX5SeZjY7");
            break;
        case 5:
            Application.OpenURL("https://maps.app.goo.gl/7LM7Q9LhfFFVy8PP9");
            break;
        }
    }
}
