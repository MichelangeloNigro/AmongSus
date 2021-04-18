using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
IEnumerator timer()
    {
        yield return new WaitForSeconds(Manager.Instance.TimeForvotatione);
        Manager.Instance.timerTable.Raise();
        gameObject.SetActive(false);
    }
    private void OnEnable()
    {
        StartCoroutine(timer());
    }
}
