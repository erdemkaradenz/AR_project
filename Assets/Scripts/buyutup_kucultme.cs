using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buyutup_kucultme : MonoBehaviour
{

    public Transform modelTransform;
    private float aradakiMesafe;
    private Vector3 buyukluk;

    void Start()
    {
        buyukluk = modelTransform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount==2)
        {
            Touch touchZero = Input.GetTouch(0);
            Touch touchOne = Input.GetTouch(1);
        
            if (touchZero.phase == TouchPhase.Began || touchOne.phase == TouchPhase.Began) {
                aradakiMesafe = Vector2.Distance(touchZero.position, touchOne.position);
            }
            else if (touchZero.phase == TouchPhase.Moved || touchOne.phase == TouchPhase.Moved) {
            float currentDistance = Vector2.Distance(touchZero.position, touchOne.position);
            float scaleFactor = currentDistance / aradakiMesafe;

            // Ölçeklendirme sınırları belirleniyor
            float minScale = 0.5f;
            float maxScale = 2.0f;

            // Yeni ölçek değeri, başlangıç ölçeğiyle çarpılarak elde ediliyor
            float newScale = Mathf.Clamp(buyukluk.x * scaleFactor, minScale, maxScale);

            // Modelin ölçeğini güncelleme
            modelTransform.localScale = new Vector3(newScale, newScale, newScale);
        
        }
        
        }
    }
}
