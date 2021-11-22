using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu( menuName = "Matchmaker skins", order = 1)]
public class MatchmakerSkin : ScriptableObject
{
    public List<Sprite> skins = new List<Sprite>();
}
