using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class soru_cevaplari : MonoBehaviour
{
   public GameObject ipucu_wrong1;
   public GameObject ipucu_wrong2;
   public GameObject ipucu_wrong3;
   public void yanlisCevap(string planetName){
    if (planetName == "answer1")
    {
        dogruCevap.SetActive(false);
        nextQuestion.SetActive(false);
        ipucu_wrong2.SetActive(false);
        ipucu_wrong3.SetActive(false);
        if (ipucu_wrong1.activeSelf==false)
        {
            ipucu_wrong1.SetActive(true);
        }
        else
        {
            ipucu_wrong1.SetActive(false);
        }
    }
    else if (planetName=="answer2")
    {
        dogruCevap.SetActive(false);
        nextQuestion.SetActive(false);
        ipucu_wrong1.SetActive(false);
        ipucu_wrong3.SetActive(false);
        if (ipucu_wrong2.activeSelf==false)
        {
            ipucu_wrong2.SetActive(true);
        }
        else
        {
            ipucu_wrong2.SetActive(false);
        }
    }
    else if (planetName=="answer3")
    {
        dogruCevap.SetActive(false);
        nextQuestion.SetActive(false);
        ipucu_wrong1.SetActive(false);
        ipucu_wrong2.SetActive(false);
        if (ipucu_wrong3.activeSelf==false)
        {
            ipucu_wrong3.SetActive(true);
        }
        else
        {
            ipucu_wrong3.SetActive(false);
        }
    }

   }

    public GameObject dogruCevap;
    public GameObject nextQuestion;
   public void DogruCevap(){
    dogruCevap.SetActive(true);
    nextQuestion.SetActive(true);
    ipucu_wrong1.SetActive(false);
    ipucu_wrong2.SetActive(false);
    ipucu_wrong3.SetActive(false);
   }
}
