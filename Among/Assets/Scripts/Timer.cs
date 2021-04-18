using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
   [SerializeField] float time;
IEnumerator timer()
    {
        yield return new WaitForSeconds(time);
        gameObject.SetActive(false);
    }
    private void OnEnable()
    {
        StartCoroutine(timer());
    }
}
