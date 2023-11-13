using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TaskManager : MonoBehaviour
{
    [Header("Player:")]
    public PlayerCollection Player;
    public GameObject PlayerManager;

    [Header("Task Descriptions")]
    public TMP_Text Description;

    [Header("Tutorial Task")]
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

    [Header("Task 1 Part 3:")]
    public bool ActivatedTask12 = false;
    public List<string> Quest12;
    public bool CompleteTask12 = false;
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
        Player = PlayerManager.GetComponent<PlayerCollection>();
        Description.text = "Tutorial: Find the little boy";
    }
    private void Update()
    {
        //gives the reward to player if all the necessary items are collected
        //Tutroial Quest
        if (TutorialQuest.Count == 3)
        {
            CompleteTutorialTask = true;
            RewardTutorial.SetActive(false); //removes the barrier
            Description.text = "Tutorial Complete: Find the way to the village.";
            Player.Inventory.RemoveAll(x => TutorialQuest.Contains(x));
            TutorialQuest.Clear();
        }

        //Quest 1
        if (Quest1.Count == 1)
        {
            CompleteTask1 = true;
            RewardTutorial2.SetActive(false);
            Description.text = "Quest1 Part1 Complete: Return to Mama Joji";
            Quest1.Clear();
        }
        if (Quest11.Count == 1)
        {
            CompleteTask11 = true;
            Description.text = "Quest1 Part2 Complete: Return to Mama Joji";
            Quest11.Clear();
        }
        if (Quest12.Count == 1)
        {
            CompleteTask12 = true;
            RewardTutorial3.SetActive(false);
            Player.Inventory.Add(RewardQuest1.name);
            Quest12.Clear();
        }

        //Quest2
        if (Quest2.Count == 1)
        {
            CompleteTask2 = true;
            RewardTutorial4.SetActive(false);
            Description.text = "Quest2 Complete: Return to Mama Joji";
            Player.Inventory.Add(RewardQuest2.name);
            Quest2.Clear(); 
        }

        //Quest3
        if (Quest3.Count == 3)
        {
            CompleteTask3 = true;
            Description.text = "Quest3 Complete: Return to herbalist";
            Player.Inventory.Add(RewardQuest3.name);
            Quest3.Clear();
        }

        //Quest4
        if (Quest4.Count == 3)
        {
            CompleteTask4 = true;
            Player.Inventory.Add(RewardQuest4.name);
            Description.text = "Quest4 Complete: Return to the Hungry Villiager.";
            Quest4.Clear();
        }

        //Quest5
        if (Quest5.Count == 0 && ActivatedTask5 == true)
        {
            CompleteTask5 = true;
            Player.Inventory.Add(RewardQuest5.name);
            Description.text = "Quest5 Complete: Go to your friend's house.";
            Quest5.Clear();
            RewardTutorial5.SetActive(false);
        }

    }
}
