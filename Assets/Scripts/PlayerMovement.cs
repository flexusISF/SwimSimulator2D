using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;

public class PlayerMovement : MonoBehaviour
{
    public Transform transform;
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
        if(transform.position.x < -7.5f)
        {
            transform.position = new Vector3(-7.5f, transform.position.y, transform.position.z);
        }
       if(transform.position.x > 7.5f)
        {
            transform.position = new Vector3(7.5f, transform.position.y, transform.position.z);
        }
       
  
}

}
