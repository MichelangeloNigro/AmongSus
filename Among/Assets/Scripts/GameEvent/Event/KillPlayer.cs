using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour
{
    [SerializeField] Riutilizzabile.GameEvent kill;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Manager.Instance.currentTarget = other.gameObject;

            kill.Raise();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Manager.Instance.currentTarget = null;
            kill.Raise();
        }
    }
}
