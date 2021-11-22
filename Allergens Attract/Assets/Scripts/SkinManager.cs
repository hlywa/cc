using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SkinManager : MonoBehaviour
{
    [SerializeField] private SpriteRenderer sr;
    [SerializeField] private MatchmakerSkin matchMakerskin;
    private int selectedSkin;
    [SerializeField] private string LevelName;

    public void Awake()
    {
        PlayerPrefs.SetInt("selectedCharacter", 0);
    }
    public void NextOption()
    {
        selectedSkin++;
        if (selectedSkin == matchMakerskin.skins.Count)
        {
            selectedSkin = 0;
        }
        sr.sprite = matchMakerskin.skins[selectedSkin];
    }

    public void BackOption()
    {
        selectedSkin--;
        if(selectedSkin < 0)
        {
            selectedSkin = matchMakerskin.skins.Count - 1;
        }

        sr.sprite = matchMakerskin.skins[selectedSkin];
    }

    public void PlayGame()
    {
        PlayerPrefs.SetInt("selectedCharacter", selectedSkin);
        SceneManager.LoadScene(LevelName);
    }
}
