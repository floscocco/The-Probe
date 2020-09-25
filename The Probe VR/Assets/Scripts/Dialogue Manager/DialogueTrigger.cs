using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;
    //private float _cooldown = 2f;
    //private float _coolDownTimer;

    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            TriggerDialogue();
        }
        
    }

    private void Update()
    {
        //if (_coolDownTimer > 0)
        //{
        //    _coolDownTimer -= Time.deltaTime;
        //}
        //else
        //{
        //    _coolDownTimer = 0;
        //}


        if (Input.GetKeyUp(KeyCode.N))
        {
            FindObjectOfType<DialogueManager>().DisplayNextSentence();
           // _coolDownTimer = _cooldown;
        }  
    }
}
