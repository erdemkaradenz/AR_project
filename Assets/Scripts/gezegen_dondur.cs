using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gezegen_dondur : MonoBehaviour
{
    
    public float donusHizi = 5f;

    void Update()
    {
        transform.Rotate(0f,donusHizi*Time.deltaTime,0f);
    }
}
