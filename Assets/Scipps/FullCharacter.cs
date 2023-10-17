using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class FullCharacter : ScriptableObject
{
    public List<CharacterParts> parts = new List<CharacterParts>();

    [System.Serializable]
    public class CharacterParts
    {
        public string partName;
        public ScriptableObject part;

        public CharacterParts(string _name, ScriptableObject _part)
        {
            partName = _name;
            part = _part;
        }
    }
}
