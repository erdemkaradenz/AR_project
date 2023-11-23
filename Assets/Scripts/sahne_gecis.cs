using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sahne_gecis : MonoBehaviour
{

    
    public void Sahne_gec(string sahneAdi){
        SceneManager.LoadScene(sahneAdi);
    }

}
