using System.Threading.Tasks;
using TMPro;
using UnityEngine;
using static UnityEditor.Progress;

public class CollectableScript : MonoBehaviour
{
    public PlayerCollection Collected;
    public GameObject Player;
    public TMP_Text MainTaskDisplay;
    public TaskManager TaskManager;
    public GameObject Tasks;

    [Header("Task Checks:")]
    public bool MainTask;
    public bool TutorialTask;
    public bool Task1;
    public bool Task2;
    public bool Task3;
    public bool Task4;
    public bool Task5;

    void Start()
    {
        Collected = Player.GetComponent<PlayerCollection>();
        TaskManager = Tasks.GetComponent<TaskManager>();
    }


    void Update()
    {

    }

    private void OnMouseDown()
    {

        if (TutorialTask == true)
        {
            if (TaskManager.ActivatedTutorialTask == true)
            {
                if (Collected.Found)
                {
                    gameObject.SetActive(false);
                    Collected.Inventory.Add(gameObject.name);
                    MainTaskDisplay.color = Color.gray;
                    MainTaskDisplay.fontStyle = FontStyles.Strikethrough;
                }

                TaskManager.TutorialQuest.Add(gameObject.name);
            }
        }

        if (Task1 == true)
        {
            if (TaskManager.ActivatedTask1 == true)
            {
                if (Collected.Found)
                {
                    gameObject.SetActive(false);
                    Collected.Inventory.Add(gameObject.name);
                    MainTaskDisplay.color = Color.gray;
                    MainTaskDisplay.fontStyle = FontStyles.Strikethrough;
                }

                TaskManager.Quest1.Add(gameObject.name);
            }
        }

        if (Task2 == true)
        {
            if (TaskManager.ActivatedTask2 == true)
            {
                if (Collected.Found)
                {
                    gameObject.SetActive(false);
                    Collected.Inventory.Add(gameObject.name);
                    MainTaskDisplay.color = Color.gray;
                    MainTaskDisplay.fontStyle = FontStyles.Strikethrough;
                }

                TaskManager.Quest2.Add(gameObject.name);
            }
        }

        if (Task3 == true)
        {
            if (TaskManager.ActivatedTask3 == true)
            {
                if (Collected.Found)
                {
                    gameObject.SetActive(false);
                    Collected.Inventory.Add(gameObject.name);
                    MainTaskDisplay.color = Color.gray;
                    MainTaskDisplay.fontStyle = FontStyles.Strikethrough;
                }

                TaskManager.Quest3.Add(gameObject.name);
            }
        }

        if (Task4 == true)
        {
            if (TaskManager.ActivatedTask4 == true)
            {
                if (Collected.Found)
                {
                    gameObject.SetActive(false);
                    Collected.Inventory.Add(gameObject.name);
                    MainTaskDisplay.color = Color.gray;
                    MainTaskDisplay.fontStyle = FontStyles.Strikethrough;
                }

                TaskManager.Quest4.Add(gameObject.name);
            }
        }

        if (Task5 == true)
        {
            if (TaskManager.ActivatedTask5 == true)
            {
                if (Collected.Found)
                {
                    gameObject.SetActive(false);
                    Collected.Inventory.Add(gameObject.name);
                    MainTaskDisplay.color = Color.gray;
                    MainTaskDisplay.fontStyle = FontStyles.Strikethrough;
                }

                TaskManager.Quest5.Add(gameObject.name);
            }
        }
    }
}
