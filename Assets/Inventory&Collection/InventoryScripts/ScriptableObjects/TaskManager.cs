using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskManager : MonoBehaviour
{
    [Header("Tutorial Task")]
    public bool ActivatedTutorialTask = false;
    public List<string> TutorialQuest;

    [Header("Task 1:")]
    public bool ActivatedTask1 = false;
    public List<string> Quest1;

    [Header("Task 2:")]
    public bool ActivatedTask2 = false;
    public List<string> Quest2;

    [Header("Task 3:")]
    public bool ActivatedTask3 = false;
    public List<string> Quest3;

    [Header("Task 4:")]
    public bool ActivatedTask4 = false;
    public List<string> Quest4;

    [Header("Task 5:")]
    public bool ActivatedTask5 = false;
    public List<string> Quest5;

    private void Update()
    {
        
    }
}
