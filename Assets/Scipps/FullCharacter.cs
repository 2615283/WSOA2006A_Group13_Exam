using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class FullCharacter : ScriptableObject
{
    public CharacterParts[] parts;

    [System.Serializable]
    public class CharacterParts
    {
        public string partName;
        public CharacterCreatorData part;
    }
}
