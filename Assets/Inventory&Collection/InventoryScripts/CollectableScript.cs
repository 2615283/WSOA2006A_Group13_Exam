using System.Threading.Tasks;
using TMPro;
using UnityEngine;
using static UnityEditor.Progress;

public class CollectableScript : MonoBehaviour
{
    public PlayerCollection Collected;
    public GameObject Player;
    public TMP_Text MainTaskDisplay;

    [Header("Task Checks:")]
    public bool MainTask;
    public bool Task1;
    public bool Task2;
    public bool Task3;
    public bool Task4;
    public bool Task5;

    void Start()
    {
        Collected = Player.GetComponent<PlayerCollection>();
    }


    void Update()
    {

    }

    private void OnMouseDown()
    {
        if (Collected.Found)
        {
            gameObject.SetActive(false);
            Collected.Inventory.Add(gameObject.name);
            MainTaskDisplay.color = Color.gray;
            MainTaskDisplay.fontStyle = FontStyles.Strikethrough;
        }
    }
}
