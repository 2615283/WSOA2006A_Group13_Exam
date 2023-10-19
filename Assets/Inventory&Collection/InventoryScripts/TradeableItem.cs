using TMPro;
using UnityEngine;

public class TradeableItem : MonoBehaviour
{
    public PlayerCollection Collected;
    public GameObject Player;

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
        }
    }
}
