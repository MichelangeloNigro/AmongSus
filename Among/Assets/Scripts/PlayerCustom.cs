using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "PlayerPref_", menuName = "Data/PlayerPref")]
public class PlayerCustom : ScriptableObject
{
    public type tipo;
    public Color colore;
    public float vel;
    public enum type
    {
        Impostor,
        Normal
    }

}
