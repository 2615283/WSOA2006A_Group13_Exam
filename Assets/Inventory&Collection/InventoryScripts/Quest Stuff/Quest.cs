using System.Collections;
using UnityEngine;

public class Quest
{
   public QuestObject Object { get; private set; }
    public QuestStatus Status { get; private set; }

    public Quest(QuestObject _Object)
    {
        Object = _Object;
    }

    /*public IEnumerator StartQuest()
    {
        Status = QuestStatus.Started;
        
        //Insert StartDialogue
        //yield return DialogueManager.Instance.ShowDialogue(Object.StartDialogue);
    }

    public IEnumerator CompleteQuest()
    {
        Status = QuestStatus.Completed;

        //Insert CompleteDialogue
        //yield return DialogueManager.Instance.ShowDialogue(Object.CompleteDialogue);

        var inventory = PlayerCollection.GetInventory();
        if (Object.RequiredItems != null)
        {
            inventory.RemoveItem(Object.RequiredItems);
        }
    }*/
}
    public enum QuestStatus { None, Started, Completed }

