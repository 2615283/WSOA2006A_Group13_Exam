using TMPro;
using UnityEngine;
using static UnityEditor.Progress;

public class CollectableScript : MonoBehaviour
{
    public PlayerCollection Collected;
    public GameObject Player;
    public TMP_Text TaskDisplay;

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
            TaskDisplay.color = Color.gray;
            TaskDisplay.fontStyle = FontStyles.Strikethrough;
        }
    }
}
