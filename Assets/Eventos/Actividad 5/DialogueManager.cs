using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DialogueManager : MonoBehaviour
{
    public NPC npc;
    public GameObject dialogueUI;
    public Text dialogueText;

    private void OnEnable()
    {
        npc.onInteraction += ShowDialogue;
    }

    private void OnDisable()
    {
        npc.onInteraction -= ShowDialogue;
    }

    private void ShowDialogue()
    {
        dialogueUI.SetActive(true);
        dialogueText.text = "Hello, traveler!";
    }
}
