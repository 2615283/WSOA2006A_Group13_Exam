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
