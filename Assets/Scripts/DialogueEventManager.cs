using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DialogueEventManager : MonoBehaviour
{
    public static UnityEvent Task1CompletedEvent = new UnityEvent();

    // Add more events as needed

    // Function to trigger Task 1 completion event
    public static void TriggerTask1CompletedEvent()
    {
        Task1CompletedEvent.Invoke();
    }
}
