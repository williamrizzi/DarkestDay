using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorchScript : MonoBehaviour
{
    public GameController controller;

    //Duration
    public float timer;
    public float maxTime;

    //Light
    public bool lamp;

    //Reset
    public bool reset;

    //light level
    public int lightLevel;

    //lights
    public GameObject[] lights;
    public GameObject endLight;

    public bool pauseTimer;


    // Start is called before the first frame update
    void Start()
    {
        controller = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();

        maxTime = 25;
        timer = maxTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (lamp == false)
        {
            if (reset)
            {
                timer = maxTime;
            }
            if (pauseTimer == false)
            {                
                if (timer > 0)
                {
                    timer -= Time.deltaTime;
                }
                if (timer <= 0)
                {
                    controller.loseGame = true;
                }
            }           

            if (lightLevel == 1)
            {
                if (timer > 12)
                {
                    lights[0].SetActive(true);
                    lights[1].SetActive(false);
                    lights[2].SetActive(false);
                    lights[3].SetActive(false);
                }
                else if (timer > 8 && timer <= 12)
                {
                    lights[0].SetActive(false);
                    lights[1].SetActive(true);
                    lights[2].SetActive(false);
                    lights[3].SetActive(false);
                }
                else if (timer > 4 && timer <= 8)
                {
                    lights[0].SetActive(false);
                    lights[1].SetActive(false);
                    lights[2].SetActive(true);
                    lights[3].SetActive(false);
                }
                else if (timer > 0 && timer <= 4)
                {
                    lights[0].SetActive(false);
                    lights[1].SetActive(false);
                    lights[2].SetActive(false);
                    lights[3].SetActive(true);
                }
                else if (timer <= 0)
                {
                    lights[0].SetActive(false);
                    lights[1].SetActive(false);
                    lights[2].SetActive(false);
                    lights[3].SetActive(false);
                }
            }
            else if (lightLevel == 2)
            {
                if (timer > 25)
                {
                    lights[0].SetActive(true);
                    lights[1].SetActive(false);
                    lights[2].SetActive(false);
                    lights[3].SetActive(false);
                }
                else if (timer > 18 && timer <= 25)
                {
                    lights[0].SetActive(false);
                    lights[1].SetActive(true);
                    lights[2].SetActive(false);
                    lights[3].SetActive(false);
                }
                else if (timer > 12 && timer <= 18)
                {
                    lights[0].SetActive(false);
                    lights[1].SetActive(false);
                    lights[2].SetActive(true);
                    lights[3].SetActive(false);
                }
                else if (timer > 6 && timer <= 12)
                {
                    lights[0].SetActive(false);
                    lights[1].SetActive(false);
                    lights[2].SetActive(false);
                    lights[3].SetActive(true);
                }
                else if (timer <= 0)
                {
                    lights[0].SetActive(false);
                    lights[1].SetActive(false);
                    lights[2].SetActive(false);
                    lights[3].SetActive(false);
                }
            }
            else if (lightLevel == 3)
            {
                if (timer > 35)
                {
                    lights[0].SetActive(true);
                    lights[1].SetActive(false);
                    lights[2].SetActive(false);
                    lights[3].SetActive(false);
                }
                else if (timer > 25 && timer <= 35)
                {
                    lights[0].SetActive(false);
                    lights[1].SetActive(true);
                    lights[2].SetActive(false);
                    lights[3].SetActive(false);
                }
                else if (timer > 15 && timer <= 25)
                {
                    lights[0].SetActive(false);
                    lights[1].SetActive(false);
                    lights[2].SetActive(true);
                    lights[3].SetActive(false);
                }
                else if (timer > 6 && timer <= 15)
                {
                    lights[0].SetActive(false);
                    lights[1].SetActive(false);
                    lights[2].SetActive(false);
                    lights[3].SetActive(true);
                }
                else if (timer <= 0)
                {
                    lights[0].SetActive(false);
                    lights[1].SetActive(false);
                    lights[2].SetActive(false);
                    lights[3].SetActive(false);
                }
            }
            else if (lightLevel == 4)
            {
                if (timer > 45)
                {
                    lights[0].SetActive(true);
                    lights[1].SetActive(false);
                    lights[2].SetActive(false);
                    lights[3].SetActive(false);
                }
                else if (timer > 30 && timer <= 45)
                {
                    lights[0].SetActive(false);
                    lights[1].SetActive(true);
                    lights[2].SetActive(false);
                    lights[3].SetActive(false);
                }
                else if (timer > 20 && timer <= 30)
                {
                    lights[0].SetActive(false);
                    lights[1].SetActive(false);
                    lights[2].SetActive(true);
                    lights[3].SetActive(false);
                }
                else if (timer > 10 && timer <= 20)
                {
                    lights[0].SetActive(false);
                    lights[1].SetActive(false);
                    lights[2].SetActive(false);
                    lights[3].SetActive(true);
                }
                else if (timer <= 0)
                {
                    lights[0].SetActive(false);
                    lights[1].SetActive(false);
                    lights[2].SetActive(false);
                    lights[3].SetActive(false);
                }
            }
        }
        if(lamp == true)
        {
            lights[0].SetActive(true);
            lights[1].SetActive(false);
            lights[2].SetActive(false);
            lights[3].SetActive(false);
        }

    }

    public void WinLights()
    {
        timer = 300;
        lights[0].SetActive(false);
        lights[1].SetActive(false);
        lights[2].SetActive(false);
        lights[3].SetActive(false);
        endLight.SetActive(true);
    }
    public void LoseLights()
    {
        timer = 0;
        lights[0].SetActive(false);
        lights[1].SetActive(false);
        lights[2].SetActive(false);
        lights[3].SetActive(false);
        endLight.SetActive(false);
    }

}
