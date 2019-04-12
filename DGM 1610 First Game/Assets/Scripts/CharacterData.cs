using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class CharacterData : ScriptableObject
{
    //public character Value;?
    //Need to fill in what it actually needs
    public Animal PlayerCharacter;
    public FloatData Health;
    public FloatData Ammo;
    public FloatData Energy;
}
