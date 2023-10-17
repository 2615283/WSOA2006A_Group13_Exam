using UnityEngine;

public class CollectableScript : MonoBehaviour
{
    public PlayerCollection Collected;
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        Collected = Player.GetComponent<PlayerCollection>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if (Collected.Found)
        {
            gameObject.SetActive(false);
        }
    }
}
