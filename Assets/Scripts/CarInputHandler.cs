using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarInputHandler : MonoBehaviour
{
    //Components 
    DriftController driftController;

    //Awake is called when the script instance is being loaded
    void Awake()
    {
        driftController = GetComponent<DriftController>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 inputVector = Vector2.zero;

        inputVector.x = Input.GetAxis("Horizontal");
        inputVector.y = Input.GetAxis("Vertical");

        driftController.setInputVector(inputVector);
    }
}
