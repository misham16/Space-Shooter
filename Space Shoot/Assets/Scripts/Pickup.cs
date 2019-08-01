using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    private MeshCollider mc;
    private AudioSource aus;
   
     void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag ("Boundary") || other.CompareTag ("Enemy"))
        {
            return;
        }
        if (other.CompareTag ("Player"))
        {
            mc = other.GetComponent <MeshCollider> () ;
            mc.enabled = false;
            new WaitForSecondsRealtime (5);
        }
        Destroy (gameObject);
        
    }
    
}
