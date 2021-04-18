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
   
    bool isinVent = false;
    public void kill()
    {
        killB.interactable = false;
        var body = Instantiate(prefabBody, Manager.Instance.currentTarget.transform.position, Quaternion.identity);
        body.GetComponent<SpriteRenderer>().color = Manager.Instance.currentTarget.GetComponent<Movement>().data.colore;
        Destroy(Manager.Instance.currentTarget);
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
    }
    private void OutVent()
    {
        characterSprite.SetActive(true);
        isinVent = false;
        foreach (GameObject item in arrows)
        {
            item.SetActive(false);
        }
    }
  
   
}
