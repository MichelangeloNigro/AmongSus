using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImpostorButtons : MonoBehaviour
{
    [SerializeField] GameObject prefabBody;
    [SerializeField] GameObject characterSprite;
    [SerializeField] Button killB;
    [SerializeField] GameObject[] arrows;
    Coroutine curr_corutine;
    [SerializeField] UnityEngine.InputSystem.OnScreen.OnScreenStick controller;

    bool isinVent = false;
    public void kill()
    {
        if (curr_corutine == null)
            curr_corutine = StartCoroutine(killTimer());

    }
    public void Vent()
    {
        if (!isinVent)
        {
            InVent();
        }
        else
        {
            OutVent();
        }

    }

    private void InVent()
    {
        characterSprite.SetActive(false);
        isinVent = true;
        foreach (GameObject item in arrows)
        {
            item.SetActive(true);
        }
        controller.enabled = false;
        killB.gameObject.SetActive(false);
    }
    private void OutVent()
    {
        characterSprite.SetActive(true);
        isinVent = false;
        foreach (GameObject item in arrows)
        {
            item.SetActive(false);
        }
        controller.enabled = true;
        killB.gameObject.SetActive(true);

    }

    IEnumerator killTimer()
    {
        killB.interactable = false;
        Manager.Instance.currentTarget.SetActive(false);
       var body = Instantiate(prefabBody, Manager.Instance.currentTarget.transform.position, Quaternion.identity);
        body.SetActive(false);
        body.GetComponent<SpriteRenderer>().color = Manager.Instance.currentTarget.GetComponent<Movement>().data.colore;
        yield return new WaitForSeconds(2f);
        body.SetActive(true);
        Destroy(Manager.Instance.currentTarget);
        if (Manager.Instance.TotalNormalPlayer > 1)
        {
            Manager.Instance.TotalNormalPlayer--;
            Debug.Log("kill");

        }
        else
        {
            Application.Quit();
            Debug.Log("exit");
        }
        curr_corutine = null;
    }

}
