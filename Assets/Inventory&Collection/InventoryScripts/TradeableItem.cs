using TMPro;
using UnityEngine;

public class TradeableItem : MonoBehaviour
{
    public PlayerCollection Collected;
    public GameObject Player;

    public AudioSource PickupSound;

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
            Collected.Fire.SetActive(true);

            PlayPickupSound();
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
