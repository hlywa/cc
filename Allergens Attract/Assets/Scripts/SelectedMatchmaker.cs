using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectedMatchmaker : MonoBehaviour
{
    public int selectedSkinIndex = 0;
    public SpriteRenderer sr;
    public MatchmakerSkin skinList;

    public void Start()
    {
        
        selectedSkinIndex = PlayerPrefs.GetInt("selectedCharacter", 0);
        sr.sprite = skinList.skins[selectedSkinIndex];
    }
}
