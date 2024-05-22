using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerMovement : MonoBehaviour
{
    //public Transform transform;

    public Transform respawnPoint;
    


    public float speed = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (UnityEngine.Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
        }

        if (UnityEngine.Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);
        }
        if(transform.position.x < -2.5f)
        {
            transform.position = new Vector3(-2.5f, transform.position.y, transform.position.z);
        }
       if(transform.position.x > 2.5f)
        {
            transform.position = new Vector3(2.5f, transform.position.y, transform.position.z);
        }
       
  
}

    public void Respawn()
    {
        respawnPoint = GameObject.Find("Respawn Point").transform;
        transform.position = new Vector3(0, -4, 0);
    }
    
}
