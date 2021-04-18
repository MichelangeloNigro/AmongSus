using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NearInteractable : MonoBehaviour
{
    [SerializeField] Riutilizzabile.GameEvent nearInteractable;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Interactable"))
        {
            nearInteractable.Raise();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Interactable"))
        {
            nearInteractable.Raise();
        }
    }
}
