using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TaskManager : MonoBehaviour
{
    [Header("Player:")]
    public PlayerCollection Player;
    public GameObject PlayerManager;

    [Header("UIChecks: ")]
    public UIManager UIChecks;
    public GameObject UIManagerObject;

    [Header("Task Descriptions")]
    public TMP_Text Description;

    [Header("Tutorial Task:")]
    public bool ActivatedTutorialTask = false;
    public List<string> TutorialQuest;
    public bool CompleteTutorialTask = false;
    public GameObject RewardTutorial;

    [Header("Task 1:")]
    public bool ActivatedTask1 = false;
    public List<string> Quest1;
    public bool CompleteTask1 = false;
    public GameObject RewardTutorial2;

    [Header("Task 1 Part 2:")]
    public bool ActivatedTask11 = false;
    public List<string> Quest11;
    public bool CompleteTask11 = false;
    public GameObject RewardQuest1;
    public GameObject RewardTutorial3;

    [Header("Task 2:")]
    public bool ActivatedTask2 = false;
    public List<string> Quest2;
    public bool CompleteTask2 = false;
    public GameObject RewardQuest2;
    public GameObject RewardTutorial4;

    [Header("Task 3:")]
    public bool ActivatedTask3 = false;
    public List<string> Quest3;
    public bool CompleteTask3 = false;
    public GameObject RewardQuest3;

    [Header("Task 4:")]
    public bool ActivatedTask4 = false;
    public List<string> Quest4;
    public bool CompleteTask4 = false;
    public GameObject RewardQuest4;

    [Header("Task 5:")]
    public bool ActivatedTask5 = false;
    public List<string> Quest5;
    public bool CompleteTask5 = false;
    public GameObject RewardQuest5;
    public GameObject RewardTutorial5;

    private void Start()
    {
        UIChecks = UIManagerObject.GetComponent<UIManager>();
        Player = PlayerManager.GetComponent<PlayerCollection>();
        Description.text = "Tutorial: Find the little boy";
    }
    private void Update()
    {
        if (Player.TutorialCompleteMessage == true)
        {
           Description.text = "Tutorial: Find the items and give them to the boy.";
        }

        //gives the reward to player if all the necessary items are collected
        //Tutroial Quest
        if (TutorialQuest.Count == 3)
        {
            Description.text = "Tutorial Complete: Talk to the boy.";
            if (UIChecks.Talked == true)
            {
                CompleteTutorialTask = true;
                RewardTutorial.SetActive(false); //removes the barrier
                Description.text = "Tutorial Complete: Find the way to the village.";
                Player.Inventory.RemoveAll(x => TutorialQuest.Contains(x));
                TutorialQuest.Clear();

                //Dialogue
                Player.DialoguePanel.SetActive(true);
                Player.Dialogue.OnTask1Completed();
            }
        }

        //Quest 1
        if (Player.StartQuest1Message == true)
        {
            Description.text = "Quest1: Take the package to the hospital";
        }
        if (UIChecks.DeliveredPackage == true)
        {
            CompleteTask1 = true;
            RewardTutorial2.SetActive(false);
            Description.text = "Quest1 Part1 Complete: Return to Mama Joji";
            Player.Inventory.RemoveAll(x => Quest1.Contains(x));
            Quest1.Clear();
        }

        if (Player.StartQuest1Part2Message == true)
        {
            Description.text = "Quest1 Part2: Take the letter to Baba Jonah";
        }

        if (Player.NPC2Talk == true)
        {
            CompleteTask11 = true;
            Description.text = "Quest1 Part2 Complete: Return to Mama Joji";
            Player.Inventory.RemoveAll(x => Quest11.Contains(x));
            Player.Inventory.Add(RewardQuest1.name);
            RewardTutorial3.SetActive(false);
            Quest11.Clear();
            Player.NPC2Talk = false;
        }
         
        //Quest2
        if (Player.StartQuest2Message == true)
        {
            Description.text = "Quest2: Find the beehive";
        }
        if (Quest2.Count == 1)
        {
            Description.text = "Quest2 Complete: Return to Mama Joji";

            if (UIChecks.Talked == true)
            {
                CompleteTask2 = true;
                RewardTutorial4.SetActive(false);
                Description.text = "You need help - Go talk to the herbalist";
                Player.Inventory.RemoveAll(x => Quest2.Contains(x));
                Player.Inventory.Add(RewardQuest2.name);
                Quest2.Clear();

                //Dialogue
                Player.DialoguePanel.SetActive(true);
                Player.Dialogue.TaskHoneyProcess();
            }
        }

        //Quest3
        if (Player.StartQuest3Message == true)
        {
            Description.text = "Quest3: Find the ingredients for the herbalist.";
        }
        if (Quest3.Count == 3)
        {
            Description.text = "Quest3 Complete: Return to herbalist";
            if (UIChecks.Talked == true)
            {
                CompleteTask3 = true;
                Description.text = "You hear a loud rumble, go find the Hungry Villager";
                Player.Inventory.RemoveAll(x => Quest3.Contains(x));
                Player.Inventory.Add(RewardQuest3.name);
                Quest3.Clear();

                //Dialogue
                Player.DialoguePanel.SetActive(true);
                Player.Dialogue.Task5Return();
            }
        }

        //Quest4
        if (Player.StartQuest4Message == true)
        {
            Description.text = "Quest4: Find a fish and ingredients.";
        }
        if (Quest4.Count == 3)
        {
            Description.text = "Quest4 Complete: Return to the Hungry Villiager.";
            if (UIChecks.Talked == true)
            {
                CompleteTask4 = true;
                Player.Inventory.Add(RewardQuest4.name);  
                Player.Inventory.RemoveAll(x => Quest4.Contains(x));
                Quest4.Clear();

                //Dialogue
                Player.DialoguePanel.SetActive(true);
                Player.Dialogue.Task6Complete();
            }
        }

        //Quest5
        if (Player.StartQuest5Message == true)
        {
            Description.text = "Quest5: Talk to the herbalist.";
        }
        if (Quest5.Count == 0 && ActivatedTask5 == true)
        {
            if (UIChecks.Talked == true)
            {
                CompleteTask5 = true;
                Player.Inventory.Add(RewardQuest5.name);
                Description.text = "Quest5 Complete: Go to your friend's house.";
                Quest5.Clear();
                RewardTutorial5.SetActive(false);

                //Dialogue
                Player.DialoguePanel.SetActive(true);
                Player.Dialogue.Task7Mixing();

                ActivatedTask5 = false;
            }
            
        }

    }
}
