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
            Manager.Instance.currentminigame = other.GetComponent<MinigameHolder>().prefabMinigame;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Interactable"))
        {
            nearInteractable.Raise();
            Manager.Instance.currentminigame = null;
        }
    }
}
