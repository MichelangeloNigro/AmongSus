using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodButton : MonoBehaviour
{
public void Instanciateminigame()
    {
        Instantiate(Manager.Instance.currentminigame);
    }

}
