using UnityEngine;
using UnityEngine.UIElements;

//Delete as soon as player is imported
public class PlayerTesterMovementScript : MonoBehaviour
{
    public float xPosition;
    public float yPosition;

    void Start()
    {
        gameObject.transform.position = new Vector3(xPosition, 0, 0);
        gameObject.transform.position = new Vector3(0, yPosition, 0);
    }

    void Update()
    {
        Vector3 xmovement = new Vector3(xPosition + 1f, 0, 0);
        Vector3 ymovement = new Vector3(0, yPosition + 1f, 0);  

        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.Translate(xmovement);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.Translate(-xmovement);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.Translate(-ymovement);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.Translate(ymovement);
        }
    }
}
