using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public Text nameText;
    public Text dialogueText;
    public GameObject dialoguePanel;


    [System.Serializable]
    public class Dialogue
    {
        public string speakerName;
        [TextArea(3, 10)]
        public string dialogueText;
    }

    private Queue<Dialogue> dialogueQueue;

    public void Start()
    {
        dialogueQueue = new Queue<Dialogue>();

        // Subscribe to events
        DialogueEventManager.Task1CompletedEvent.AddListener(OnTask1Completed);


    }

    public void StartDialogue()
    {
        dialogueQueue.Clear();

        //dialogue lines for Susan and Kwame
        dialogueQueue.Enqueue(new Dialogue { speakerName = "Susan", dialogueText = "Hey there, it's going to be okay. My name's Susan. I'm a doctor. Let me help you." });
        dialogueQueue.Enqueue(new Dialogue { speakerName = "Kwame", dialogueText = "I hurt my leg really bad, ma'am. It hurts a lot." });
        dialogueQueue.Enqueue(new Dialogue { speakerName = "Susan", dialogueText = "I can see that. Don't worry, I'll fix you up. First things first, let's call an ambulance." });
        dialogueQueue.Enqueue(new Dialogue { speakerName = "Kwame", dialogueText = "Why call an ambulance when everything you will find in the hospital is right here in its most natural form?" });
        dialogueQueue.Enqueue(new Dialogue { speakerName = "Susan", dialogueText = "What do you mean?" });
        dialogueQueue.Enqueue(new Dialogue { speakerName = "Kwame", dialogueText = "Just use your phone, find out what I may need and go get it for me" });
        

        // Start dialogue
        DisplayNextLine();
    }


    private void OnTask1Completed()
    {
        // Add the next set of dialogues or any other actions here
        // For example:
        dialogueQueue.Enqueue(new Dialogue { speakerName = "Kwame", dialogueText = "You're like a wizard! If this doctor thing doesn't work out, you've got a future in magic." });
        dialogueQueue.Enqueue(new Dialogue { speakerName = "Susan", dialogueText = "Who knows, Kwame? Maybe I'll start a new trend: 'Healing silly small boys.' I'll just need a wand made of twigs!" });
        dialogueQueue.Enqueue(new Dialogue { speakerName = "Kwame", dialogueText = "I can see it now: 'The Amazing Dr. Susan and her Marvelous Medicinal Leaves!' Has a nice ring to it, don't you think?" });
        dialogueQueue.Enqueue(new Dialogue { speakerName = "Susan", dialogueText = "How did you get your leg mangled like that, by the way?" });
        dialogueQueue.Enqueue(new Dialogue { speakerName = "Kwame", dialogueText = "It is the honey… I would do anything for the honey." });
        dialogueQueue.Enqueue(new Dialogue { speakerName = "Susan", dialogueText = "You know what, I don’t judge you." });
        dialogueQueue.Enqueue(new Dialogue { speakerName = "Kwame", dialogueText = "Good thing I fell; otherwise, we would be treating bee stings on my swollen face." });

        // Start the next set of dialogues
        DisplayNextLine();
    }


    public void DisplayNextLine()
    {
        if (dialogueQueue.Count == 0)
        {
            // End dialogue
            EndDialogue();
            return;
        }

        Dialogue dialogue = dialogueQueue.Dequeue();
        nameText.text = dialogue.speakerName;
        dialogueText.text = dialogue.dialogueText;

        dialoguePanel.SetActive(true);
    }

    public void EndDialogue()
    {
        dialoguePanel.SetActive(false);
    }
}
