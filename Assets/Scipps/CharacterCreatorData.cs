using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class CharacterCreatorData : ScriptableObject
{
    public string partName;
    public int partID;

    public List<AnimationClip> partAnimations = new List<AnimationClip>();
}
