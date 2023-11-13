using System.Collections.Generic;
using TMPro;
using UnityEditor.ShaderKeywordFilter;
using UnityEngine;

public class PlayerCollection : MonoBehaviour
{
    [Header("Collecting:")]
    public bool Found = false;
    public List<string> Inventory;
    public bool Hospital = false;

    [Header("NPC UI")]
    public bool NPCNear = false;
    public UIManager CheckInteraction;
    public GameObject CheckInteractionManager;

    [Header("Display")]
    public TMP_Text InventoryDisplay;
    public GameObject HospitalDisplay;
    public GameObject FireDisplay;

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
    public bool NPC2Talk = false;

    public bool FinalQuest = false;

    [Header("NPC Checks")]
    public bool TutorialNPC = false;
    public bool NPC1 = false;
    public bool NPC2 = false;
    public bool NPC3 = false;
    public bool NPC4 = false;
    public bool NPC5 = false;

    [Header("Item Manager:")]
    [Header("Tutorial Items")]
    public GameObject TutorialQuestList;
    public GameObject TutorialItem1;
    public GameObject TutorialItem2;
    public GameObject TutorialItem3;

    [Header("Quest 1 Items")]
    public GameObject Quest1List1;
    public GameObject Quest1List2;
    public GameObject Quest1Item1;
    public GameObject Quest1Item2;

    [Header("Quest 2 Items")]
    public GameObject Quest2List;
    public GameObject Quest2Item1;

    [Header("Quest 3 Items")]
    public GameObject Quest3List;
    public GameObject Quest3Item1;
    public GameObject Quest3Item2;
    public GameObject Quest3Item3;

    [Header("Quest 4 Items")]
    public GameObject Quest4List;
    public GameObject Quest4Item1;
    public GameObject Quest4Item2;
    public GameObject Quest4Item3;

    [Header("Dialogue")]
    public DialogueManager Dialogue;
    public GameObject DialoguePanel;

    [Header("Controllers")]
    public GameObject VillageEntrance;
    public GameObject HospitalQuest;
    public GameObject Beehive;
    public GameObject Fire;
    public bool StartFire = false;

    [Header("Quest List Controllers:")]
    public bool TutorialCompleteMessage = false;
    public bool StartQuest1Message = false;
    public bool StartQuest1Part2Message = false;
    public bool StartQuest2Message = false;
    public bool StartQuest3Message = false;
    public bool StartQuest4Message = false;
    public bool StartQuest5Message = false;

    void Start()
    {
        Inventory = new List<string>();
        Inventory.Add("Glasses");

        Dialogue = FindObjectOfType<DialogueManager>();
        DialoguePanel = Dialogue.dialoguePanel;
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

            TutorialCompleteMessage = true;

            //Dialogue
            DialoguePanel.SetActive(true);
            Dialogue.StartDialogue();

        }
        //sets NPCQuest check as false once task is active
        if (ActivateTask.ActivatedTutorialTask == true)
        {
            NPCTutorialQuest = false;
            TutorialCompleteMessage = false;
        }

        //Quest 1.1
        //Checks if the correct NPC has been talked to and activates the task
        if (CheckInteraction.Talked == true && NPCQuest1 == true)
        {
            ActivateTask.ActivatedTask1 = true;
            Quest1Item1.SetActive(true);

            StartQuest1Message = true;

            //Dialogue
            DialoguePanel.SetActive(true);
            Dialogue.Task2Dialogue();

        }
        //sets NPCQuest check as false once task is active
        if (ActivateTask.ActivatedTask1 == true)
        {
            NPCQuest1 = false;
            StartQuest1Message = false;
        }

        //Quest 1.2
        //Checks if the correct NPC has been talked to and activates the task
        if (CheckInteraction.Talked == true && NPCQuest11 == true)
        {
            ActivateTask.ActivatedTask11 = true;
            
            StartQuest1Part2Message = true;
            Quest1Item2.SetActive(true);

            //Dialogue
            DialoguePanel.SetActive (true);
            Dialogue.Task2Complete();
        }
        //sets NPCQuest check as false once task is active
        if (ActivateTask.ActivatedTask11 == true)
        {
            NPCQuest11 = false;
            StartQuest1Part2Message = false;
        }

        //Quest 2
        //Checks if the correct NPC has been talked to and activates the task
        if (CheckInteraction.Talked == true && NPCQuest2 == true)
        {
            ActivateTask.ActivatedTask2 = true;
            StartQuest2Message = true;
            
            Quest2Item1.SetActive(true);

            //Dialogue
            DialoguePanel.SetActive(true);
            Dialogue.TaskHoneyDialogue();
        }
        //sets NPCQuest check as false once task is active
        if (ActivateTask.ActivatedTask2 == true)
        {
            NPCQuest2 = false;
            StartQuest2Message = false;
        }

        //Quest 3
        //Checks if the correct NPC has been talked to and activates the task
        if (CheckInteraction.Talked == true && NPCQuest3 == true)
        {
            ActivateTask.ActivatedTask3 = true;
            Quest3Item1.SetActive(true);
            Quest3Item2.SetActive(true);
            Quest3Item3.SetActive(true);
            
            StartQuest3Message = true;

            //Dialogue
            DialoguePanel.SetActive(true);
            Dialogue.Task5Dialogue();
        }
        //sets NPCQuest check as false once task is active
        if (ActivateTask.ActivatedTask3 == true)
        {
            NPCQuest3 = false;
            StartQuest3Message = false;
        }

        //Quest 4
        //Checks if the correct NPC has been talked to and activates the task
        if (CheckInteraction.Talked == true && NPCQuest4 == true)
        {
            ActivateTask.ActivatedTask4 = true;
            Quest4Item1.SetActive(true);
            Quest4Item2.SetActive(true);
            Quest4Item3.SetActive(true);
            
            StartQuest4Message = true;

            //Dialogue
            DialoguePanel.SetActive(true);
            Dialogue.Task6Dialogue();
        }
        //sets NPCQuest check as false once task is active
        if (ActivateTask.ActivatedTask4 == true)
        {
            NPCQuest4 = false;
            StartQuest4Message = false;
        }

        //Quest 5
        //Checks if the correct NPC has been talked to and activates the task
        if (CheckInteraction.Talked == true && NPCQuest5 == true)
        {
            ActivateTask.ActivatedTask5 = true;
            
            StartQuest5Message = true;

            //Dialogue
            DialoguePanel.SetActive(true);
            Dialogue.Task7Dialogue();
        }
        //sets NPCQuest check as false once task is active
        if (ActivateTask.ActivatedTask5 == true)
        {
            NPCQuest5 = false;
            StartQuest5Message = false;
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
            TutorialNPC = true;
            TutorialQuestList.SetActive(true);
        }

        if (collision.gameObject.name == "NPC1")
        {
            NPCQuest1 = true;
            NPC1 = true;
            Quest1List1.SetActive(true);
        }

        if (collision.gameObject.name == "NPC1" && ActivateTask.CompleteTask1 == true)
        {
            NPCQuest11 = true;
            NPC1 = true;
            Quest1List2.SetActive(true);
        }
        if (collision.gameObject.name == "NPC1" && ActivateTask.CompleteTask11 == true)
        {
            NPCQuest2 = true;
            NPC1 = true;
            Quest2List.SetActive(true);
        }

        if (collision.gameObject.name == "NPC2")
        {
            NPC2 = true;
        }

        if (ActivateTask.Quest11.Count >= 1)
        {
            if (/*CheckInteraction.Talked == true && */NPC2)
            {
                NPC2Talk = true;

                //Dialogue
                DialoguePanel.SetActive(true);
                Dialogue.Task3Dialogue();
            }
        }

        if (collision.gameObject.name == "NPC3")
        {
            NPCQuest3 = true;
            NPC3 = true;
            Quest3List.SetActive(true);
        }
        if (collision.gameObject.name == "NPC4")
        {
            NPCQuest4 = true;
            NPC4 = true;
            Quest4List.SetActive(true);
        }
        if (collision.gameObject.name == "NPC3" && ActivateTask.CompleteTask3 == true)
        {
            NPCQuest5 = true;
            NPC3 = true;
        }

        //Checks if player is at the hospital
        if (collision.gameObject.name == "HospitalDelivery")
        {
            Hospital = true;
            HospitalDisplay.SetActive(true);
        }

        //Checks if player has entered the village
        if (collision.gameObject.name == "VillageEntrance")
        {
            ActivateTask.Description.text = "Find Mama Joji (Hint she has the greyest hair)";
            VillageEntrance.SetActive(false);
        }

        //Checks if player found the beehive
        if (collision.gameObject.name == "FindBeehive")
        {
            ActivateTask.Description.text = "You need to create a fire, find a stick.";
            Beehive.SetActive(false);
        }

        //Checks if player is able to make a fire
        if (collision.gameObject.name == "CreateFire")
        {
            StartFire = true;
            FireDisplay.SetActive(true);
        }

        //Checks if player is near their friend
        if (collision.gameObject.name == "NPC5")
        {
           FinalQuest = true;
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Found = false;
        NPCNear = false;
        Hospital = false;
        StartFire = false;

        TutorialNPC = false;
        NPC1 = false;
        NPC2 = false;
        NPC3 = false;
        NPC4 = false;
        NPC5 = false;
    }

}
