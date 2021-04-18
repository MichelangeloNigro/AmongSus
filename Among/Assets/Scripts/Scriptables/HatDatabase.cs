using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "HatDatabase", menuName = "Data/Hats")]

public class HatDatabase : ScriptableObject
{
   public List<Sprite> hats;
}
