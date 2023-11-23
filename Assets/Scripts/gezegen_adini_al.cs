using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gezegen_adini_al : MonoBehaviour
{
    public String gezegenAdi= "";
    
    public void GezegenAdiniAl(string gezegen){
        gezegenAdi = gezegen;
        PlayerPrefs.SetString("secilen_gezegen",gezegenAdi);
    }

}
