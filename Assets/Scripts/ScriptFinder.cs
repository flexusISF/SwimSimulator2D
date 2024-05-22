using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptFinder : MonoBehaviour
{

    public PlayerMovement[] playerMovements;

    // Start is called before the first frame update
    void Start()
    {
        playerMovements = GameObject.FindObjectsOfType<PlayerMovement>();

        foreach(PlayerMovement scripty in playerMovements)
         Debug.Log($"Script: {scripty.gameObject.name}");
    }

   
}
