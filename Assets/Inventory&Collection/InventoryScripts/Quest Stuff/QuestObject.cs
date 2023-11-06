using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Quest/Create a new Quest")]
public class QuestObject : ScriptableObject
{
    public string Name;
    public string Description;

    //StartDialogue - will be set at the start of the quest
    //InProgressDialogue
    //CompleteDialogue - when quest is complete

    //public CollectableScript RequiredItem; //use list if multiple items are required for a quest
    public List<string> RequiredItems;
    public GameObject RewardItem;

    public bool QuestActivated;

    /*public string Names => Name;
    public string Descriptions => Description;

    //expose dialogues

    //checks if their are in progress dialogues if not rerun the start dialogue
    //public Dialog InProgressDialogue => inProgressDialogue?.Lines?.Count > 0? inProgressDialogue : StartDialogue;

    //public CollectableScript RequiredItems => RequiredItem;
    //public CollectableScript RewardItems => RewardItem;
    */
}
