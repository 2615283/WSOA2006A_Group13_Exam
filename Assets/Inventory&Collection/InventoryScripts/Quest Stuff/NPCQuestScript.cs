using Unity.VisualScripting;
using UnityEngine;

public class NPCQuestScript : MonoBehaviour

{
    public UIManager CheckInteraction;
    public GameObject CheckInteractionManager;

    public TaskManager ActivateTask;
    public GameObject TaskManager;

    void Start()
    {
        CheckInteraction = CheckInteractionManager.GetComponent<UIManager>();

        ActivateTask = TaskManager.GetComponent<TaskManager>();
    }

    void Update()
    {
        if (CheckInteraction.Talked)
        {

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "NPC1")
        {
            Debug.Log("Found");
            ActivateTask.ActivatedTask1 = true;
        }
    }
}
