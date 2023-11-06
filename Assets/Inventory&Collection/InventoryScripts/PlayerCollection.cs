using System.Collections.Generic;
using TMPro;
using UnityEditor.ShaderKeywordFilter;
using UnityEngine;

public class PlayerCollection : MonoBehaviour
{
    [Header("Collecting:")]
    public bool Found = false;
    public List<string> Inventory;

    [Header("NPC UI")]
    public bool NPCNear = false;
    public UIManager CheckInteraction;
    public GameObject CheckInteractionManager;

    [Header("Display")]
    public TMP_Text InventoryDisplay;

    [Header("Quest Control")]
    public TaskManager ActivateTask;
    public GameObject TaskManager;
    public bool NPCQuest = false;

    void Start()
    {
        Inventory = new List<string>();
    }

    void Update()
    {
        string result = string.Join("\n", Inventory);
        InventoryDisplay.text = result;

        if (CheckInteraction.Talked == true && NPCQuest == true)
        {
            ActivateTask.ActivatedTask1 = true;
        }

        if (ActivateTask.ActivatedTask1 == true)
        {
            NPCQuest = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //checks if the player is near a collectible item
        if (collision.CompareTag("Collectible"))
        {
            Found = true;
        }

        //checks if there is a interactable NPC near
        if (collision.CompareTag("NPC"))
        {
            NPCNear = true;
        }
        if (collision.gameObject.name == "NPC1")
        {
            NPCQuest = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Found = false;
        NPCNear = false;
    }

}
