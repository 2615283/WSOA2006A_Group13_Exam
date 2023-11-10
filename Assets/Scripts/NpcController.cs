using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcController : MonoBehaviour
{
    public DialogueManager dialogueManager;

    public GameObject dialoguePanel;

    public void Start()
    {
        dialogueManager = FindObjectOfType<DialogueManager>();

        dialoguePanel = dialogueManager.dialoguePanel; 
        
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            
            dialoguePanel.SetActive(true);

            dialogueManager.StartDialogue(); 
        }
    }
}
