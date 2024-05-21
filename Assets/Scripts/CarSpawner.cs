using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    public GameObject[] car;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnCars());
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    void Cars()
    {
        int rand = Random.Range(0, car.Length);
        float randXPos = Random.Range(-2f, 2f);
        Instantiate(car[rand],new Vector3(randXPos,transform.position.y,transform.position.z), Quaternion.Euler(0,0,90));
    }
    IEnumerator SpawnCars()
    {
      while(true) {


            yield return new WaitForSeconds(0.55f);
            Cars(); }

    }
}
