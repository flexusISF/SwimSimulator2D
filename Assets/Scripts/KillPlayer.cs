using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour
{
    public GameObject player;
    public Transform respawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        //respawnPoint = GameObject.Find("Respawn Point").transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D other)
    {

        Debug.Log($"Enemy hit {other.gameObject.name}");
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("KILLED PLAYER");

            player.GetComponent<PlayerMovement>().Respawn();
        }
    }
}
