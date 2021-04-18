using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImpostorButtons : MonoBehaviour
{
    [SerializeField] GameObject prefabBody;
    [SerializeField] Button killB;
public void kill()
    {
        killB.interactable = false;
    var body=    Instantiate(prefabBody,Manager.Instance.currentTarget.transform.position,Quaternion.identity);
        body.GetComponent<SpriteRenderer>().color = Manager.Instance.currentTarget.GetComponent<Movement>().data.colore;
        Destroy(Manager.Instance.currentTarget);
    }
}
