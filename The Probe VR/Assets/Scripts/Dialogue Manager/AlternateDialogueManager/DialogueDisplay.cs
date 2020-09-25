using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueDisplay : MonoBehaviour
{
    public Conversation conversation;

    public GameObject speakerLeft;
    public GameObject speakerRight;

    private ConversationUI speakerUILeft;
    private ConversationUI speakerUIRight;

    private int activeLineIndex = 0;

    
    void Start()
    {
        speakerUILeft = speakerLeft.GetComponent<ConversationUI>();
        speakerUIRight = speakerRight.GetComponent<ConversationUI>();

        speakerUILeft.Speaker = conversation.speakerLeft;
        speakerUIRight.Speaker = conversation.speakerRight;
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            AdvanceConversation();
        }
    }

    void AdvanceConversation()
    {
        if(activeLineIndex< conversation.lines.Length)
        {
            DisplayLine();
            activeLineIndex += 1;
        }
        else
        {
            speakerUILeft.Hide();
            speakerUIRight.Hide();
            activeLineIndex = 0;
        }
    }

    void DisplayLine()
    {
        Line line = conversation.lines[activeLineIndex];
        Character character = line.character;

        if (speakerUILeft.SpeakerIs(character))
        {
            SetDialogue(speakerUILeft, speakerUIRight, line.text, line.character.characterName);
        }
        else
        {
            SetDialogue(speakerUIRight, speakerUILeft, line.text, line.character.characterName);
        }
    }

    void SetDialogue(ConversationUI activeSpeakerUI, ConversationUI inactiveSpeakerUI, string text, string cName)
    {
        inactiveSpeakerUI.Hide();
        activeSpeakerUI.Dialogue = text;
        activeSpeakerUI.CharacterName = cName;
        activeSpeakerUI.Show();
    }
}
