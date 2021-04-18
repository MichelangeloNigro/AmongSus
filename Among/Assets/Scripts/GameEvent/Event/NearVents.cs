using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NearVents : MonoBehaviour
{
    [SerializeField] Riutilizzabile.GameEvent nearVents;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Vents"))
        {
            nearVents.Raise();
          //  Manager.Instance. = other.GetComponent<MinigameHolder>().prefabMinigame;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Vents"))
        {
            nearVents.Raise();
          //  Manager.Instance. = null;
        }
    }
}
