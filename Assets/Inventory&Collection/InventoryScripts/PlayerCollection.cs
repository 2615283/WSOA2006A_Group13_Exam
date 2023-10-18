using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerCollection : MonoBehaviour
{
    [Header("Collecting:")]
    public bool Found = false;
    public List<string> Herbs;
    public List<string> Plants;
    public List<string> Food;
    public List<string> Inventory;

    [Header("NPC UI")]
    public bool NPCNear = false;

    [Header("Display")]
    public TMP_Text InventoryDisplay;

    void Start()
    {
        Herbs = new List<string>();
        Plants = new List<string>();
        Food = new List<string>();

        Inventory = new List<string>();

    }

    void Update()
    {
        string result = string.Join("\n", Inventory);
        InventoryDisplay.text = result;
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
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Found = false;
        NPCNear = false;
    }

}
