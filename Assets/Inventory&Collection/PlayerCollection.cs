using UnityEngine;

public class PlayerCollection : MonoBehaviour
{
    public bool Found = false;

    void Start()
    {
        
    }

    void Update()
    {
        /*if (Input.GetMouseButtonDown(0))
        {
            if (Found)
            {
                Debug.Log("Object Found");
            }
        }*/
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Collectible"))
        {
            Found = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Found = false;
    }

}
