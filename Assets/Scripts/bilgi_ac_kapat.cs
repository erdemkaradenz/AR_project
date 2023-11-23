using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bilgi_ac_kapat : MonoBehaviour
{
    
    public GameObject model;
    public GameObject canvas; // model aktif y  apıldığında kapatılacak

    public GameObject mainCamera;
    public GameObject ArSession, ArSessionOrigin;
    public void Ac_Kapat(){
        if (mainCamera.activeSelf == true)
        {
            mainCamera.SetActive(false);
            ArSession.SetActive(true);
            ArSessionOrigin.SetActive(true);
            model.SetActive(true);
        }
        else
        {
            mainCamera.SetActive(true);
            ArSession.SetActive(true);
            ArSessionOrigin.SetActive(true);
            model.SetActive(true);
        }
    }
}
