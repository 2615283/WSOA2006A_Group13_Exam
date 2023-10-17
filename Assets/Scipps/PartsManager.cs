using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartsManager : MonoBehaviour
{
    [SerializeField]
    private FullCharacter character;

    [SerializeField]
    private string[] typeOfPart;
    [SerializeField]
    private string[] states;
    [SerializeField]
    private string[] directions;

    private Animator animator;
    private AnimationClip animClip;
    private AnimatorOverrideController animOverrideCont;
    private AnimationOverrides animOverrides;

    private void Start()
    {
        animator = GetComponent<Animator>();
        animOverrideCont = new AnimatorOverrideController(animator.runtimeAnimatorController);
        animator.runtimeAnimatorController = animOverrideCont;

        animOverrides = new AnimationOverrides(animOverrideCont.overridesCount);
        animOverrideCont.GetOverrides(animOverrides);

        PartsUpdate();
    }

    public void PartsUpdate()
    {
        for (int partIn = 0; partIn < typeOfPart.Length; partIn++)
        {
            string partTypes = typeOfPart[partIn];
            string partID = character.parts[partIn].part.partID.ToString();

            for (int stateIn = 0; stateIn < states.Length; stateIn++)
            {
                string state = states[stateIn];
                for (int directionIn = 0; directionIn < directions.Length; directionIn++)
                {
                    string direction = directions[directionIn];

                    animClip = Resources.Load<AnimationClip>("PlayerAnimations/" + partTypes + "/" + partTypes + "_" + partID + "_" + state + "_" + direction);

                    animOverrides[partTypes + "_" + 0 + "_" + state + "_" + direction] = animClip;
                }
            }
        }

        animOverrideCont.ApplyOverrides(animOverrides);
    }

    public class AnimationOverrides : List<KeyValuePair<AnimationClip, AnimationClip>>
    { 
        public AnimationOverrides(int cap) : base(cap) { }

        public AnimationClip this[string name]
        {
            get { return this.Find(x => x.Key.name.Equals(name)).Value; }

            set
            {
                int indices = this.FindIndex(x => x.Key.name.Equals(name));

                if (indices != -1)
                {
                    this[indices] = new KeyValuePair<AnimationClip, AnimationClip>(this[indices].Key, value);
                }
            }
        }
    }
}
