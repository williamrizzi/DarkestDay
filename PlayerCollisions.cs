using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCollisions : MonoBehaviour
{
    //Camera
    public CameraSmooth cameraScript;

    public Text textCarryBack;

    //Fuel Carry
    public int fuelCarry;
    public int maxFuelCarry;

    //UpgradePanel
    public GameObject upgradePanel;

    //Torch
    public TorchScript torchScript;

    void Start()
    {
        maxFuelCarry = 5;
        fuelCarry = 0;
        torchScript = GetComponentInChildren<TorchScript>();
        cameraScript = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<CameraSmooth>();
    }

    void Update()
    {
        textCarryBack.text = fuelCarry.ToString();
    }
    
    public void OnTriggerEnter2D(Collider2D col)
    {
        
        if(col.tag == "Fuel")
        {
            if(fuelCarry < maxFuelCarry)
            {
                fuelCarry += 1;
                Destroy(col.gameObject);
            }
        }
        if(col.tag == "Furnace")
        {
            col.GetComponent<Furnace>().fuel += fuelCarry;
            fuelCarry = 0;
        }
        if(col.tag == "UpgradeStone")
        {
            upgradePanel.gameObject.SetActive(true);
        }
        if (col.tag == "Campfire")
        {
            torchScript.reset = true;
        }

        //setores
        if(col.name == "s0")
        {
            cameraScript.setorAtual = 0;
        }
        if (col.name == "s1")
        {
            cameraScript.setorAtual = 1;
        }
        if (col.name == "s2")
        {
            cameraScript.setorAtual = 2;
        }
        if (col.name == "s3")
        {
            cameraScript.setorAtual = 3;
        }
        if (col.name == "s4")
        {
            cameraScript.setorAtual = 4;
        }
        if (col.name == "s5")
        {
            cameraScript.setorAtual = 5;
        }
        if (col.name == "s6")
        {
            cameraScript.setorAtual = 6;
        }
        if (col.name == "s7")
        {
            cameraScript.setorAtual = 7;
        }
        if (col.name == "s8")
        {
            cameraScript.setorAtual = 8;
        }
        if(col.tag == "PauseTimer")
        {
            torchScript.pauseTimer = true;
        }


    }


    public void OnTriggerStay2D(Collider2D col)
    {
        if (col.tag == "PauseTimer")
        {
            torchScript.pauseTimer = true;
        }
    }

    public void OnTriggerExit2D(Collider2D col)
    {
        if (col.tag == "UpgradeStone")
        {
            upgradePanel.gameObject.SetActive(false);
        }
        if (col.tag == "Campfire")
        {
            torchScript.reset = false;
        }
        if (col.tag == "PauseTimer")
        {
            torchScript.pauseTimer = false;
        }
    }
}
