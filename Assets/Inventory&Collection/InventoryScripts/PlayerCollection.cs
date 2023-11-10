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
    public bool NPCTutorialQuest = false;
    public bool NPCQuest1 = false;
    public bool NPCQuest11 = false;
    public bool NPCQuest12 = false;
    public bool NPCQuest2 = false;
    public bool NPCQuest3 = false;
    public bool NPCQuest4 = false;
    public bool NPCQuest5 = false;

    [Header("Item Manager:")]
    [Header("Tutorial Items")]
    public GameObject TutorialItem1;
    public GameObject TutorialItem2;
    public GameObject TutorialItem3;

    [Header("Quest 1 Items")]
    public GameObject Quest1Item1;
    public GameObject Quest1Item2;

    [Header("Quest 2 Items")]
    public GameObject Quest2Item1;

    [Header("Quest 3 Items")]
    public GameObject Quest3Item1;
    public GameObject Quest3Item2;
    public GameObject Quest3Item3;

    [Header("Quest 4 Items")]
    public GameObject Quest4Item1;
    public GameObject Quest4Item2;
    public GameObject Quest4Item3;

    void Start()
    {
        Inventory = new List<string>();
        Inventory.Add("Glasses");
    }

    void Update()
    {
        string result = string.Join("\n", Inventory);
        InventoryDisplay.text = result;

        //Tutorial
        //Checks if the correct NPC has been talked to and activates the task
        if (CheckInteraction.Talked == true && NPCTutorialQuest== true)
        {
            ActivateTask.ActivatedTutorialTask = true;
            TutorialItem1.SetActive(true);
            TutorialItem2.SetActive(true);
            TutorialItem3.SetActive(true);
        }
        //sets NPCQuest check as false once task is active
        if (ActivateTask.ActivatedTutorialTask == true)
        {
            NPCTutorialQuest = false;
        }

        //Quest 1.1
        //Checks if the correct NPC has been talked to and activates the task
        if (CheckInteraction.Talked == true && NPCQuest1 == true)
        {
            ActivateTask.ActivatedTask1 = true;
            Quest1Item1.SetActive(true);
        }
        //sets NPCQuest check as false once task is active
        if (ActivateTask.ActivatedTask1 == true)
        {
            NPCQuest1 = false;
        }

        //Quest 1.2
        //Checks if the correct NPC has been talked to and activates the task
        if (CheckInteraction.Talked == true && NPCQuest11 == true)
        {
            ActivateTask.ActivatedTask1 = true;
            Quest1Item2.SetActive(true);
        }
        //sets NPCQuest check as false once task is active
        if (ActivateTask.ActivatedTask1 == true)
        {
            NPCQuest11 = false;
        }

        //Quest 2
        //Checks if the correct NPC has been talked to and activates the task
        if (CheckInteraction.Talked == true && NPCQuest2 == true)
        {
            ActivateTask.ActivatedTask2 = true;
            Quest2Item1.SetActive(true);
        }
        //sets NPCQuest check as false once task is active
        if (ActivateTask.ActivatedTask2 == true)
        {
            NPCQuest2 = false;
        }

        //Quest 3
        //Checks if the correct NPC has been talked to and activates the task
        if (CheckInteraction.Talked == true && NPCQuest3 == true)
        {
            ActivateTask.ActivatedTask3 = true;
            Quest3Item1.SetActive(true);
            Quest3Item2.SetActive(true);
            Quest3Item3.SetActive(true);
        }
        //sets NPCQuest check as false once task is active
        if (ActivateTask.ActivatedTask3 == true)
        {
            NPCQuest3 = false;
        }

        //Quest 4
        //Checks if the correct NPC has been talked to and activates the task
        if (CheckInteraction.Talked == true && NPCQuest4 == true)
        {
            ActivateTask.ActivatedTask4 = true;
            Quest4Item1.SetActive(true);
            Quest4Item2.SetActive(true);
            Quest4Item3.SetActive(true);
        }
        //sets NPCQuest check as false once task is active
        if (ActivateTask.ActivatedTask4 == true)
        {
            NPCQuest4 = false;
        }

        //Quest 5
        //Checks if the correct NPC has been talked to and activates the task
        if (CheckInteraction.Talked == true && NPCQuest5 == true)
        {
            ActivateTask.ActivatedTask5 = true;
        }
        //sets NPCQuest check as false once task is active
        if (ActivateTask.ActivatedTask5 == true)
        {
            NPCQuest5 = false;
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

        //checks which NPC the player talked to
        if (collision.gameObject.name == "NPCTutorial")
        {
            NPCTutorialQuest = true;
        }
        if (collision.gameObject.name == "NPC1")
        {
            NPCQuest1 = true;
        }
        if (collision.gameObject.name == "NPC1" && ActivateTask.CompleteTask1 == true)
        {
            NPCQuest11 = true;
        }
        if (collision.gameObject.name == "NPC2")
        {
            NPCQuest2 = true;
        }
        if (collision.gameObject.name == "NPC3")
        {
            NPCQuest3 = true;
        }
        if (collision.gameObject.name == "NPC4")
        {
            NPCQuest4 = true;
        }
        if (collision.gameObject.name == "NPC5")
        {
            NPCQuest5 = true;
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Found = false;
        NPCNear = false;
    }

}
