using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeutralButton : MonoBehaviour
{
   public void SetState(GameObject gameObject)
    {
        gameObject.SetActive(!gameObject.activeSelf);
    }
}
