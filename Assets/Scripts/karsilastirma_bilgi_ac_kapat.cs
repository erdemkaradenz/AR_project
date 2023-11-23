using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class karsilastirma_bilgi_ac_kapat : MonoBehaviour
{
    public GameObject canvas;

    public void Ac_Kapat(){
        if (canvas.activeSelf==true)
        {
            canvas.SetActive(false);
        }
        else
        {
            canvas.SetActive(true);
        }
    }
}
