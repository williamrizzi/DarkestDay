using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    //has a fuel spawned
    public bool spawned;

    //prefab fuel
    public GameObject fuelObj;

    public float timer;
    public float maxTimer;

    // Start is called before the first frame update
    void Start()
    {
        maxTimer = 100;
        spawned = false;
        timer = 2.0f;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;       
        if(timer < 0)
        {
            Instantiate(fuelObj, transform.position, Quaternion.identity);
            timer = maxTimer;
        }
            
        
    }
}
