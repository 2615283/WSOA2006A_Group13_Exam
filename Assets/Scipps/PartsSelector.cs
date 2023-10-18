using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PartsSelector : MonoBehaviour
{
    [SerializeField]
    private FullCharacter character;
    [SerializeField] private PartSelection[] partSelections;


    private void Start()
    {
        for (int i = 0; i < partSelections.Length; i++)
        {
            CurrentParts(i);
        }
    }

    public void NextPart(int IndexParts)
    {
        if (ConfirmValue(IndexParts))
        {
           if (partSelections[IndexParts].partCurrentInd < partSelections[IndexParts].partOptions.Length - 1)
           {
                partSelections[IndexParts].partCurrentInd++;
           }
           else
           {
                partSelections[IndexParts].partCurrentInd = 0;
           }

            UpdateParts(IndexParts);
        }
    }

    public void PreviousPart(int IndexParts)
    {
        if (ConfirmValue(IndexParts))
        {
            if (partSelections[IndexParts].partCurrentInd > 0)
            {
                partSelections[IndexParts].partCurrentInd--;
            }
            else
            {
                partSelections[IndexParts].partCurrentInd = partSelections[IndexParts].partOptions.Length - 1;
            }

            UpdateParts(IndexParts);
        }
    }

    private bool ConfirmValue(int IndexParts)
    {
        if (IndexParts > partSelections.Length || IndexParts < 0)
        {
            Debug.Log("Nope...");
            return false;
        }
        else
        {
            return true;
        }
    }

    private void CurrentParts(int IndexParts)
    {
        //partSelections[IndexParts].partNameTXT.text = character.parts[IndexParts].part.partName;

        partSelections[IndexParts].partCurrentInd = character.parts[IndexParts].part.partID;
    }

    public void UpdateParts(int IndexParts)
    {
        partSelections[IndexParts].partNameTXT.text = partSelections[IndexParts].partOptions[partSelections[IndexParts].partCurrentInd].partName;

        character.parts[IndexParts].part = partSelections[IndexParts].partOptions[partSelections[IndexParts].partCurrentInd];
    }

    [System.Serializable]
    public class PartSelection
    {
        public string partName;
        public CharacterCreatorData[] partOptions;
        public TextMeshProUGUI partNameTXT;
        public int partCurrentInd;
    }
}
