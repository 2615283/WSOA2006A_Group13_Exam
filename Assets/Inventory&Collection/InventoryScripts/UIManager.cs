using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    [Header("Game UI")]
    public GameObject TaskScreen;
    public GameObject InventoryScreen;
    public GameObject PauseScreen;
    public GameObject StartScreen;

    [Header("NPC UI")]
    public GameObject DialogueScreen;
    public GameObject TradeScreen;

    public PlayerCollection NPCCheck;
    public GameObject PlayerScript;

    [Header("Checks:")]
    public bool Talked = false;


    void Start()
    {
        //instantiates the PlayerCollection Script
        NPCCheck = PlayerScript.GetComponent<PlayerCollection>();
    }


    void Update()
    {
        //opens Pause Screen
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseScreen.SetActive(true);
            Time.timeScale = 0;
        }

        //opens Task Screen
        if (Input.GetKeyDown(KeyCode.T))
        {
            TaskScreen.SetActive(true);
        }

        //opens Inventory Screen
        if (Input.GetKeyDown(KeyCode.E))
        {
            InventoryScreen.SetActive(true);
        }

        /*//opens the Trade Screen if NPC is nearby
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (NPCCheck.NPCNear)
            {
                TradeScreen.SetActive(true);
            }
        }*/

        //starts dialogue scene with NPC - possibly going to change
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (NPCCheck.NPCNear)
            {
                DialogueScreen.SetActive(true);
                Talked = true;
            }
        }

    }

    public void Play()
    {
        //Game resumes when button is pressed
        PauseScreen.SetActive(false);
        Time.timeScale = 1;
    }

    public void ResetGame()
    {
        SceneManager.LoadScene("UI Test");
        Time.timeScale = 1;
    }

    public void QuitToStart()
    {
        StartScreen.SetActive(true);
        PauseScreen.SetActive(false);
        Time.timeScale = 1;
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void FinishDialogue()
    {
        DialogueScreen.SetActive(false);
        Talked = false;
    }
}
