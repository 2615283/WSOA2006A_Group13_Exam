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
    public GameObject MapScreen;
    public GameObject EndScreen;

    [Header("NPC UI")]
    public GameObject DialogueScreen;

    public PlayerCollection NPCCheck;
    public GameObject PlayerScript;

    [Header("Checks:")]
    public bool Talked = false;
    public bool DeliveredPackage = false;

    [Header("Triggers:")]  
    public GameObject Fire;
    public GameObject Honey;
    public float FireTimer = 2.0f;
    public float HoneyTimer = 2.0f;
    private bool FireStarter;


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

        //opens map Screen
        if (Input.GetKeyDown(KeyCode.M))
        {
            MapScreen.SetActive(true);
            Time.timeScale = 0;
        }

        //starts dialogue scene with NPC - possibly going to change
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (NPCCheck.NPCNear)
            {
                DialogueScreen.SetActive(true);
                Talked = true;
            }
        }

        //If player is at hospital wait for key press
        if (Input.GetKeyDown(KeyCode.X))
        {
            if (NPCCheck.Hospital == true)
            {
                DeliveredPackage = true;
                NPCCheck.HospitalDisplay.SetActive(false);
                NPCCheck.HospitalQuest.SetActive(false);
            }

            if (NPCCheck.StartFire == true)
            {
                NPCCheck.FireDisplay.SetActive(false);
                FireStarter = true;              
            }
        }

        //triggers timers for fire and honey
        if (FireStarter == true)
        {
            FireTimer -= Time.deltaTime;
        }

        if (FireTimer <= 0)
        {
            Fire.SetActive(true);
            HoneyTimer -= Time.deltaTime;
            FireStarter = false;

            if (HoneyTimer <= 0)
            {
                Honey.SetActive(true);
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

    public void CloseMapScreen()
    {
        MapScreen.SetActive(false);
        Time.timeScale = 1;
    }
}
