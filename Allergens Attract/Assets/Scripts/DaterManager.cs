using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//its missing something HMM HMM 
public class DaterManager : MonoBehaviour
{
    public Image leftSelectedImage;
    public Image rightSelectedImage;
    private DateableCharacter firstSelected;
    private DateableCharacter secondSelected;
    public Button startDateButton;

    //we want it to know which button is on and which is off so we need a reference to all the buttons (SPOILER ALERT A LIST??? AN ARRAY??? HMMMM)
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //we want it to check and see how many buttons are turned on!
        //then we want to show the ready button when there are 2 that are turned on, and disable the other buttons.
        //if there are less than 2 selected, then allow the player to select another dater before showing the ready button.

        //spoiler alert: look for tutorials about how buttons work, and what interactable, disable, enable all do.
    }

    public void SelectDater(DateableCharacter character)
    {
        if (firstSelected == null)
        {
            firstSelected = character;
            leftSelectedImage.sprite = character.GetComponent<SpriteRenderer>().sprite;
        } else if (secondSelected == null)
        {
            secondSelected = character;
            rightSelectedImage.sprite = character.GetComponent<SpriteRenderer>().sprite;
        }

        if (firstSelected != null && secondSelected != null)
        {
            startDateButton.interactable = true;
        }
    }

    public void ClearSelected()
    {
        firstSelected = null;
        leftSelectedImage.sprite = null;
        secondSelected = null;
        rightSelectedImage.sprite = null;
        var buttons = GameObject.FindGameObjectsWithTag("Character Button");
        foreach (GameObject foundObject in buttons) {
            foundObject.GetComponent<Button>().interactable = true;
        }
        startDateButton.interactable = false;

    }

    public void StartDate()
    {
        PlayerPrefs.SetString("firstSelected", firstSelected.characterName);
        PlayerPrefs.SetString("secondSelected", secondSelected.characterName);
    }
}
