using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCar : MonoBehaviour
{
    public GameObject[] cars; 

        // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(Spawn), 0, 5);    
    }

    void Spawn()
    {
        //if (Random.Range(0, 100) < 40) return;

        int selected = Random.Range(0, cars.Length);
        GameObject car = Instantiate(cars[selected], transform.position, Quaternion.identity);
        car.AddComponent<DriveForward>();


    }
}
