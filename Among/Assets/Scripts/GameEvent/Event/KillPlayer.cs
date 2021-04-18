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
            if (other.GetComponent<Movement>().data.tipo == PlayerCustom.type.Normal)
            {
                Manager.Instance.currentTarget = other.gameObject;

                kill.Raise();
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (other.GetComponent<Movement>().data.tipo == PlayerCustom.type.Normal)
            {

                Manager.Instance.currentTarget = null;
                kill.Raise();
            }
        }
    }
}
