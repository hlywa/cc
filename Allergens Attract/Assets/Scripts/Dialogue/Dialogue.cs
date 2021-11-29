using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    [Header("Ink JSON")]
    [SerializeField] private TextAsset InkJSON;

    private bool playerInRange;
    private void Awake()
    {
        playerInRange = true;

    }


    private void Update()
    {
        if (playerInRange)
        {
         

        }
    }
}
