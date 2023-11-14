using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public TMP_Text nameText;
    public TMP_Text dialogueText;
    public GameObject dialoguePanel;

    public GameObject letterPanel;

    public UIManager Checks;
    public GameObject UIManagers;

    [System.Serializable]
    public class Dialogue
    {
        public string speakerName;
        [TextArea(3, 10)]
        public string dialogueText;
    }

    private Queue<Dialogue> dialogueQueue;

    public void Start()
    {
        dialogueQueue = new Queue<Dialogue>();

        // Subscribe to events
        DialogueEventManager.Task1CompletedEvent.AddListener(OnTask1Completed);

        Checks = UIManagers.GetComponent<UIManager>();
    }

    //meets the boy
    public void StartDialogue() //Activates Tutorial
    {
        dialogueQueue.Clear();

        
        dialogueQueue.Enqueue(new Dialogue { speakerName = "You", dialogueText = "Hey there, it's going to be okay. I'm a doctor. Let me help you." });
        dialogueQueue.Enqueue(new Dialogue { speakerName = "Kwame", dialogueText = "I hurt my leg really bad. It hurts a lot." });
        dialogueQueue.Enqueue(new Dialogue { speakerName = "You", dialogueText = "I can see that. Don't worry, I'll fix you up. First things first, let's call an ambulance." });
        dialogueQueue.Enqueue(new Dialogue { speakerName = "Kwame", dialogueText = "Why call an ambulance when everything you will find in the hospital is right here in its most natural form?" });
        dialogueQueue.Enqueue(new Dialogue { speakerName = "You", dialogueText = "What do you mean?" });
        dialogueQueue.Enqueue(new Dialogue { speakerName = "Kwame", dialogueText = "Just use your phone, find out what I may need and go get it for me" });
        

        
        DisplayNextLine();
    }

    //after collecting items for the boy
    public void OnTask1Completed() // Tutorial is Complete
    {
        
        dialogueQueue.Enqueue(new Dialogue { speakerName = "Kwame", dialogueText = "You're like a wizard! If this doctor thing doesn't work out, you've got a future in magic." });
        dialogueQueue.Enqueue(new Dialogue { speakerName = "You", dialogueText = "Who knows, Kwame? Maybe I'll start a new trend: 'Healing silly small boys.' I'll just need a wand made of twigs!" });
        dialogueQueue.Enqueue(new Dialogue { speakerName = "Kwame", dialogueText = "I can see it now: 'The Amazing Doctor and their Marvelous Medicinal Leaves!' Has a nice ring to it, don't you think?" });
        dialogueQueue.Enqueue(new Dialogue { speakerName = "You", dialogueText = "How did you get your leg mangled like that, by the way?" });
        dialogueQueue.Enqueue(new Dialogue { speakerName = "Kwame", dialogueText = "It is the honey… I would do anything for the honey." });
        dialogueQueue.Enqueue(new Dialogue { speakerName = "You", dialogueText = "You know what, I don’t judge you." });
        dialogueQueue.Enqueue(new Dialogue { speakerName = "Kwame", dialogueText = "Good thing I fell; otherwise, we would be treating bee stings on my swollen face." });

        
        DisplayNextLine();
    }

    //first interaction with mama joji
    public void Task2Dialogue() // Activates Quest 1
    {
        
        dialogueQueue.Enqueue(new Dialogue { speakerName = "You", dialogueText = "Are you Mama Joji?" });
        dialogueQueue.Enqueue(new Dialogue { speakerName = "Mama Joji", dialogueText = "I've got the greyest head in town, of course, it is me, and you've come just in time. I need your help with a special delivery for The Town Hospital." });
        dialogueQueue.Enqueue(new Dialogue { speakerName = "You", dialogueText = "Where’s That?" });
        dialogueQueue.Enqueue(new Dialogue { speakerName = "Mama Joji", dialogueText = "Your friend said you’re a doctor. I thought you would know." });
        dialogueQueue.Enqueue(new Dialogue { speakerName = "You", dialogueText = "I am, but I'm not from around here." });
        dialogueQueue.Enqueue(new Dialogue { speakerName = "Mama Joji", dialogueText = "Just look for the building with the big red plus sign, not a red X! Not a red… you know what? A red plus sign." });

        
        DisplayNextLine();
    }

    //task2 complete
    public void Task2Complete() //Activates Quest 1 Part2
    {
        
        dialogueQueue.Enqueue(new Dialogue { speakerName = "Mama Joji", dialogueText = "Ahh, back so soon, I need your help with a special delivery for Baba Jonah." });
        dialogueQueue.Enqueue(new Dialogue { speakerName = "You", dialogueText = "Well, are you going to tell me what he looks like?" });
        dialogueQueue.Enqueue(new Dialogue { speakerName = "Mama Joji", dialogueText = "You will have no trouble locating him. He is the tall handsome man, grey like me, on the other side of the village. The hair he has left on his head is quite interesting to look at, in a good way... Take this and run along before it gets dark." });

        
        DisplayNextLine();
    }

    //task3- to Babe Jona
    public void Task3Dialogue() //Complete Quest 1 Part2
    {
        
        dialogueQueue.Enqueue(new Dialogue { speakerName = "You", dialogueText = "Are you Baba Jonah?" });
        dialogueQueue.Enqueue(new Dialogue { speakerName = "Baba Jonah", dialogueText = "Who wants to know, my child?" });
        dialogueQueue.Enqueue(new Dialogue { speakerName = "You", dialogueText = "Mama Joji sent me." });
        dialogueQueue.Enqueue(new Dialogue { speakerName = "Baba Jonah", dialogueText = "Ah, Mama Joji, she has a heart as beautiful as the rarest flower. I've always admired her from a distance." });
        dialogueQueue.Enqueue(new Dialogue { speakerName = "You", dialogueText = "She did say you have the most interesting hair on this side of town." });
        dialogueQueue.Enqueue(new Dialogue { speakerName = "Baba Jonah", dialogueText = "Interesting, you say? *takes letter*" });
        /*
        // Display the letter reading panel
        DisplayLetterPanel();
        */
        // Continue the dialogue after reading the letter
        dialogueQueue.Enqueue(new Dialogue { speakerName = "Baba Jonah", dialogueText = "Oh, Joji!! *reads letter out loud*" });
        dialogueQueue.Enqueue(new Dialogue { speakerName = "Mama Joji", dialogueText = "Dear Jonah, I find myself lost in our village's beauty, tangled in the unsaid words between us." });
        dialogueQueue.Enqueue(new Dialogue { speakerName = "Mama Joji", dialogueText = "Like the herbs we nurture, our emotions weave deep roots within our hearts. I write not just as a herbalist, but as a soul yearning for your warmth, your wisdom, and the unspoken words that dance under the moonlit sky." });
        dialogueQueue.Enqueue(new Dialogue { speakerName = "Mama Joji", dialogueText = "Perhaps, my dear Jonah, it's time to express what our hearts have known. Life is brief, akin to the herbs in our garden." });
        dialogueQueue.Enqueue(new Dialogue { speakerName = "Mama Joji", dialogueText = "Let's meet where the river meets the ancient oak tree. Under the starlit canopy, let our hearts speak, for love, like nature's healing touch, can mend the most broken spirits." });
        dialogueQueue.Enqueue(new Dialogue { speakerName = "Mama Joji", dialogueText = "Don’t forget that thing () - Tenderly, Mama Joji" });
        
        // Continue with the remaining dialogue
        dialogueQueue.Enqueue(new Dialogue { speakerName = "You", dialogueText = "You must really like her." });
        dialogueQueue.Enqueue(new Dialogue { speakerName = "Baba Jonah", dialogueText = "Since I was a little boy. Take this to her and tell her I hope she is still as beautiful as she looks in my dreams." });

        
        DisplayNextLine();
    }

   //letter
    public void DisplayLetterPanel()
    {
       
        letterPanel.SetActive(true);
                     
    }

    //Honey Dialogue
    public void TaskHoneyDialogue() //Activates Quest 2
    {
        
        dialogueQueue.Enqueue(new Dialogue { speakerName = "You", dialogueText = "Here you go, Mama. Baba Jonah is quite a looker." });
        dialogueQueue.Enqueue(new Dialogue { speakerName = "Mama Joji", dialogueText = "Heyyy!!! That's my crush you speak of!" });
        dialogueQueue.Enqueue(new Dialogue { speakerName = "You", dialogueText = "He is all yours. Besides, I'm like a baby to you guys. It would be questionable if he, you know?" });
        dialogueQueue.Enqueue(new Dialogue { speakerName = "Mama Joji", dialogueText = "No, I don’t know. Do tell?" });
        dialogueQueue.Enqueue(new Dialogue { speakerName = "You", dialogueText = "Never mind. Do you know where I might find some real honey?" });
        dialogueQueue.Enqueue(new Dialogue { speakerName = "Mama Joji", dialogueText = "Ooohhh, honey. I would love some too." });
        dialogueQueue.Enqueue(new Dialogue { speakerName = "You", dialogueText = "Well??" });
        dialogueQueue.Enqueue(new Dialogue { speakerName = "Mama Joji", dialogueText = "Walk that way. If you start to hear buzzing, don't look up." });
        dialogueQueue.Enqueue(new Dialogue { speakerName = "You", dialogueText = "And???" });
        dialogueQueue.Enqueue(new Dialogue { speakerName = "Mama Joji", dialogueText = "In shadows deep, where buzz and hum, a golden treasure, sweet and glum. To claim the prize, with bees at bay, Seek help from giants, so they say. Smoke shall veil, the bees take flight." });
        dialogueQueue.Enqueue(new Dialogue { speakerName = "You", dialogueText = "And???" });
        dialogueQueue.Enqueue(new Dialogue { speakerName = "Mama Joji", dialogueText = "Well, I can’t spell everything out for you." });

        
        DisplayNextLine();
    }

    public void TaskHoneyProcess() //Complete Quest2
    {
        
        /*dialogueQueue.Enqueue(new Dialogue { speakerName = "Susan", dialogueText = "Great, I've found the bees. Now what... What did Mama Joji say?" });
        dialogueQueue.Enqueue(new Dialogue { speakerName = "Susan", dialogueText = "Elephants!!!" }); // Assuming Susan exclaims "Elephants!!!" in response to Mama Joji's Memory
        dialogueQueue.Enqueue(new Dialogue { speakerName = "Mama Joji's Memory", dialogueText = "Smoke shall veil, the bees take flight." });
        dialogueQueue.Enqueue(new Dialogue { speakerName = "Susan", dialogueText = "In realization) I could use my glasses to burn the leaves and get rid of the bees." });*/
        dialogueQueue.Enqueue(new Dialogue { speakerName = "Mama Joji", dialogueText = "Wow, with soot on your face???" });
        dialogueQueue.Enqueue(new Dialogue { speakerName = "You", dialogueText = "Well, your advice was cryptic, but I figured it out." });
        dialogueQueue.Enqueue(new Dialogue { speakerName = "Mama Joji", dialogueText = "What advice? I was just saying something to sound wise. I'm surprised you actually got the honey." });
        dialogueQueue.Enqueue(new Dialogue { speakerName = "You", dialogueText = "In shock)... " });
        dialogueQueue.Enqueue(new Dialogue { speakerName = "Mama Joji", dialogueText = "Well, thank you. Here's your share of the honey for your troubles." });

        
        DisplayNextLine();
    }


    //villagers dialogue
    public void Task4Dialogue() //Ignore
    {
       
        dialogueQueue.Enqueue(new Dialogue { speakerName = "Villager", dialogueText = "My dear wife, her stomach hurts." });
        dialogueQueue.Enqueue(new Dialogue { speakerName = "Wife", dialogueText = "Owwwwww!" });
        dialogueQueue.Enqueue(new Dialogue { speakerName = "Villager", dialogueText = "My Son he has pimples all over his face." });
        dialogueQueue.Enqueue(new Dialogue { speakerName = "Son", dialogueText = "Ahhhh! The pimples! Noooooo!" });
        dialogueQueue.Enqueue(new Dialogue { speakerName = "Villager", dialogueText = "And me!! I'm so stressed out by all this." });
        dialogueQueue.Enqueue(new Dialogue { speakerName = "You", dialogueText = "And let me guess? You want me to traverse the Pharmacy of God to get the herbs that will help?" });
        dialogueQueue.Enqueue(new Dialogue { speakerName = "Villager", dialogueText = "That would be nice, my friend. Go to the traditional healer, he should know what to do." });

        
        DisplayNextLine();
    }

    
    //Herbalist dialogue
    public void Task5Dialogue() // Activates Quest 3
    {
        
        dialogueQueue.Enqueue(new Dialogue { speakerName = "Herbalist", dialogueText = "Ah, young one. I see you seek my help. But before I assist you, I need a special mixture of herbs for a healing potion." });
        dialogueQueue.Enqueue(new Dialogue { speakerName = "Herbalist", dialogueText = "Here are the herbs I require. Search the area around the village. Some might be hidden, guarded by nature's puzzles." });
        dialogueQueue.Enqueue(new Dialogue { speakerName = "You", dialogueText = "OKAY Old man..." });

        
        DisplayNextLine();
    }

    public void Task5Return() //Completes Quest 3 Part1
    {
       
        dialogueQueue.Enqueue(new Dialogue { speakerName = "You", dialogueText = "I've brought all the herbs you requested. What's next?" });
        dialogueQueue.Enqueue(new Dialogue { speakerName = "Herbalist", dialogueText = "Excellent work, young one. Now, you must blend these herbs together. It's a puzzle of nature, a dance of flavors and scents." });
        dialogueQueue.Enqueue(new Dialogue { speakerName = "You", dialogueText = "...*mixing ingredients*" });
        dialogueQueue.Enqueue(new Dialogue { speakerName = "Herbalist", dialogueText = "A splendid concoction! You have a keen eye and a skilled hand. This will aid my patient greatly." });
        dialogueQueue.Enqueue(new Dialogue { speakerName = "You", dialogueText = "Forgetting something?" });
        dialogueQueue.Enqueue(new Dialogue { speakerName = "Herbalist", dialogueText = "Oh, were you not paying attention? All these ingredients should help your friends." });
        dialogueQueue.Enqueue(new Dialogue { speakerName = "Herbalist", dialogueText = "As promised, here is the item for the villager. Your efforts will not be forgotten." });
        dialogueQueue.Enqueue(new Dialogue { speakerName = "You", dialogueText = "Thanks… wait, how did you know it was for that villager?" });
        dialogueQueue.Enqueue(new Dialogue { speakerName = "Herbalist", dialogueText = "Smirking) I have my ways." });

        
        DisplayNextLine();
    }

    //Back to villagers
    public void Task5Complete() //Ignore
    {
        
        dialogueQueue.Enqueue(new Dialogue { speakerName = "You", dialogueText = "I have brought the item as requested. It was a challenging but rewarding task." });
        dialogueQueue.Enqueue(new Dialogue { speakerName = "Villager", dialogueText = "Thank you for your help. Our village is fortunate to have someone as resourceful as you." });
        dialogueQueue.Enqueue(new Dialogue { speakerName = "You", dialogueText = "May I have some of those herbs, they may be of use to me later." });
        dialogueQueue.Enqueue(new Dialogue { speakerName = "Villager", dialogueText = "Here you go, and again Asante (Thank you)." });

        
        DisplayNextLine();
    }

    //Fish & Herbs Task
    public void Task6Dialogue() //Activates Quest 4
    {
        
        dialogueQueue.Enqueue(new Dialogue { speakerName = "Hungry Villager", dialogueText = "Oh, my rumbling tummy! I need a feast. Fetch me a meal, and I shall reward you handsomely. But beware, the mosquitoes here are as hungry as I am!" });

        
        DisplayNextLine();
    }

    public void Task6Complete() //Completes Quest 4
    {
        
        dialogueQueue.Enqueue(new Dialogue { speakerName = "You", dialogueText = "Here you go, Hungry Villager! A feast to satisfy your hunger and herbs to scare those mosquitoes. These herbs will keep the pests away, and the fish is as fresh as your haircut." });
        dialogueQueue.Enqueue(new Dialogue { speakerName = "Hungry Villager", dialogueText = "Ah, you've done it! My belly shall sing with joy, and the mosquitoes shall dance elsewhere! You're a lifesaver, my clever friend! Tell me, where did you learn to outsmart both my appetite and these pesky insects?" });
        dialogueQueue.Enqueue(new Dialogue { speakerName = "You", dialogueText = "Well, let's just say I've had my fair share of encounters with stubborn critters and even hungrier friends back in my hometown. It's all about finding the right recipe!" });
        dialogueQueue.Enqueue(new Dialogue { speakerName = "Hungry Villager", dialogueText = "Haha, you're not just resourceful; you're also quite the storyteller! We'll be telling tales of your cleverness for generations. Here, take this insect repellent I've crafted. May it shield you from the mosquito army on your adventures." });

        
        DisplayNextLine();
    }

    //Malaria Dialogue
    public void Task7Dialogue() // Activates Quest 5
    {
        
        dialogueQueue.Enqueue(new Dialogue { speakerName = "Herbalist", dialogueText = "Ah, it seems you've had a run-in with our notorious mosquitoes, eh? Fear not, my friend! I have just the remedy. Bring me the ingredients on this list, and we shall banish those pesky biters from your bloodstream!" }); 
        dialogueQueue.Enqueue(new Dialogue { speakerName = "You", dialogueText = "Oh, oh, this is bad! Mosquitoes got me at the dam, and now I need a cure! Help!" });
        dialogueQueue.Enqueue(new Dialogue { speakerName = "Herbalist", dialogueText = "Calm down, my friend! Panicking won't chase the mosquitoes away. Here's the list. Now, off you go, and remember, every minute you waste panicking, a mosquito throws a party inside you!" });
        dialogueQueue.Enqueue(new Dialogue { speakerName = "You", dialogueText = "But how can I carry out this task without panicking or making my condition worse than it already is!?" });

        
        DisplayNextLine();
    }

    public void Task7Mixing() //Complete Quest 5 Part1
    {
        
        dialogueQueue.Enqueue(new Dialogue { speakerName = "You", dialogueText = "I've got them! Now, please, hurry! Mix them, make the medicine, save me from this malaria misery!" });
        dialogueQueue.Enqueue(new Dialogue { speakerName = "Herbalist", dialogueText = "Oh, my dear, you're in quite a state, aren't you? Fear not, for I shall whip up the antidote. But next time, maybe consider investing in a mosquito net?" });
        dialogueQueue.Enqueue(new Dialogue { speakerName = "Herbalist", dialogueText = "..." });
        dialogueQueue.Enqueue(new Dialogue { speakerName = "Herbalist", dialogueText = "Here you go, my dramatic friend! Drink this, and let it be a lesson: in the battle against mosquitoes, wit is your best weapon, not flailing like a windmill!" });
        dialogueQueue.Enqueue(new Dialogue { speakerName = "You", dialogueText = "I'll remember that, but right now, I'm just praying this medicine works!" });
        dialogueQueue.Enqueue(new Dialogue { speakerName = "Herbalist", dialogueText = "Fret not, my friend. With this, those malaria-causing miscreants will flee your system faster than you can say 'mosquito marathon'!" });

        
        DisplayNextLine();
    }

    //Dialogues Ends

    public void DisplayNextLine()
    {
        if (dialogueQueue.Count == 0)
        {
            // End dialogue
            EndDialogue();
            Checks.Talked = false;
            return;
        }

        Dialogue dialogue = dialogueQueue.Dequeue();
        nameText.text = dialogue.speakerName;
        dialogueText.text = dialogue.dialogueText;

        dialoguePanel.SetActive(true);
    }

    public void EndDialogue()
    {
        dialoguePanel.SetActive(false);
    }
}
