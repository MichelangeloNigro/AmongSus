using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    [SerializeField] GameObject target;
    [SerializeField] GameObject player;
    public void freccia()
    {
        player.transform.position = target.transform.position;
    }
}
