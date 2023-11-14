using System.Threading.Tasks;
using TMPro;
using UnityEngine;
//using static UnityEditor.Progress;

public class CollectableScript : MonoBehaviour
{
    public PlayerCollection Collected;
    public GameObject Player;
    public TMP_Text MainTaskDisplay;
    public TaskManager TasksManager;
    public GameObject Tasks;

    public AudioSource PickupSound;

    [Header("Task Checks:")]
    public bool MainTask;
    public bool TutorialTask;
    public bool Task1;
    public bool Task11;
    public bool Task2;
    public bool Task3;
    public bool Task4;
    public bool Task5;

    void Start()
    {
        Collected = Player.GetComponent<PlayerCollection>();
        TasksManager = Tasks.GetComponent<TaskManager>();
    }


    void Update()
    {
        
    }

    private void OnMouseDown()
    {
     //checks if the correct object is being picked up and added to inventory and quest storage
        if (TutorialTask == true)
        {
            if (TasksManager.ActivatedTutorialTask == true)
            {
                if (Collected.Found)
                {
                    gameObject.SetActive(false);
                    Collected.Inventory.Add(gameObject.name);
                    MainTaskDisplay.color = Color.gray;
                    MainTaskDisplay.fontStyle = FontStyles.Strikethrough;

                    PlayPickupSound();
                }

                TasksManager.TutorialQuest.Add(gameObject.name);
            }
        }

        if (Task1 == true)
        {
            if (TasksManager.ActivatedTask1 == true)
            {
                if (Collected.Found)
                {
                    gameObject.SetActive(false);
                    Collected.Inventory.Add(gameObject.name);
                    MainTaskDisplay.color = Color.gray;
                    MainTaskDisplay.fontStyle = FontStyles.Strikethrough;

                    PlayPickupSound();
                }

                TasksManager.Quest1.Add(gameObject.name);
            }
        }

        if (Task11 == true)
        {
            if (TasksManager.ActivatedTask11 == true)
            {
                if (Collected.Found)
                {
                    gameObject.SetActive(false);
                    Collected.Inventory.Add(gameObject.name);
                    MainTaskDisplay.color = Color.gray;
                    MainTaskDisplay.fontStyle = FontStyles.Strikethrough;

                    PlayPickupSound();
                }

                TasksManager.Quest11.Add(gameObject.name);
            }
        }

        if (Task2 == true)
        {
            if (TasksManager.ActivatedTask2 == true)
            {
                if (Collected.Found)
                {
                    gameObject.SetActive(false);
                    Collected.Inventory.Add(gameObject.name);
                    MainTaskDisplay.color = Color.gray;
                    MainTaskDisplay.fontStyle = FontStyles.Strikethrough;

                    PlayPickupSound();
                }

                TasksManager.Quest2.Add(gameObject.name);
            }
        }

        if (Task3 == true)
        {
            if (TasksManager.ActivatedTask3 == true)
            {
                if (Collected.Found)
                {
                    gameObject.SetActive(false);
                    Collected.Inventory.Add(gameObject.name);
                    MainTaskDisplay.color = Color.gray;
                    MainTaskDisplay.fontStyle = FontStyles.Strikethrough;

                    PlayPickupSound();
                }

                TasksManager.Quest3.Add(gameObject.name);
            }
        }

        if (Task4 == true)
        {
            if (TasksManager.ActivatedTask4 == true)
            {
                if (Collected.Found)
                {
                    gameObject.SetActive(false);
                    Collected.Inventory.Add(gameObject.name);
                    MainTaskDisplay.color = Color.gray;
                    MainTaskDisplay.fontStyle = FontStyles.Strikethrough;

                    PlayPickupSound();
                }

                TasksManager.Quest4.Add(gameObject.name);
            }
        }

        if (Task5 == true)
        {
            if (TasksManager.ActivatedTask5 == true)
            {
                if (Collected.Found)
                {
                    gameObject.SetActive(false);
                    Collected.Inventory.Add(gameObject.name);
                    MainTaskDisplay.color = Color.gray;
                    MainTaskDisplay.fontStyle = FontStyles.Strikethrough;

                    PlayPickupSound();
                }

                TasksManager.Quest5.Add(gameObject.name);
            }
        }
    }

    private void PlayPickupSound()
    {
        if (PickupSound != null)
        {
            PickupSound.Play();
        }
    }
}
