using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConversationUI : MonoBehaviour
{
    public Image portrait;
    public Text characterName;
    public Text dialogue;

    private Character speaker;

    public Character Speaker
    {
        get { return speaker; }
        set
        {
            speaker = value;
            portrait.sprite = speaker.portrait;
            characterName.text = speaker.characterName;
        }
    }

    public string Dialogue
    {
        set { dialogue.text = value; }
    }

    public string CharacterName
    {
        set { characterName.text = value; }
    }

    public bool HasSpeaker()
    {
        return speaker != null;
    }

   public bool SpeakerIs(Character character)
    {
        return speaker == character;
    }

    public void Show()
    {
        gameObject.SetActive(true);
    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }
    
}
