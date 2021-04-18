using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Outline : MonoBehaviour
{
    
  [SerializeField] SpriteRenderer renderer;

    private void OnTriggerEnter(Collider other)
    {
    
        if (other.CompareTag("Outline"))
        {
            renderer.enabled = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Outline"))
        {
            renderer.enabled = false;
        }
    }
}
