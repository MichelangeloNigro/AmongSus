using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyNearEvent : MonoBehaviour
{
    [SerializeField] Riutilizzabile.GameEvent nearBody;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Body"))
        {
            nearBody.Raise();
            if(other.GetComponent<SpriteRenderer>())
            Manager.Instance.currentBody = other.gameObject;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Body"))
        {
            nearBody.Raise();
            Manager.Instance.currentBody = null;

        }
    }
}
