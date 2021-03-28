using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaptainController : MonoBehaviour, Interactable
{
    [SerializeField] Dialogue dialogue;

    public void Interact()
    {
        DialogueManager.Instance.ShowDialogue(dialogue);
    }
}
