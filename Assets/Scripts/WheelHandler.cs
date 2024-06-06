using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelHandler : MonoBehaviour
{

    //Components

    DriftController driftController;

    TrailRenderer trailRenderer;

    //Awake is called when the script instance is being loaded.
     void Awake()
    {
        //Get the drift controller
        driftController = GetComponentInParent<DriftController>();

        //Get the trail renderer component
        trailRenderer = GetComponent<TrailRenderer>();

        //Set the trail renderer to not emit in the start
        trailRenderer.emitting = false;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //If the car tires screeching then we'll emitt a trail.
        if (driftController.IsTireScreeching(out float lateralVelocity, out bool isBraking))
            trailRenderer.emitting = true;
        else trailRenderer.emitting = false;
    }
}
