using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Upgrades : MonoBehaviour
{
    public GameController controller;

    //fornalha - combustivel armazenado
    public Furnace furnaceScript;

    //Script Movimento - speedMod
    public PlayerMoviment moveScript;
    public int speedModLevel;

    //Player collisions - Max Carry per Level
    public PlayerCollisions collisionsScript;
    public int maxCarryLevel;

    //LightDuration
    public TorchScript torch;
    public int lightLevel;

    //Buy Battery
    public Animator anim;

    //Texts
    public Text[] textButton;
    public Text[] text;



    // Start is called before the first frame update
    void Start()
    {
        controller = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();

        speedModLevel = 1;
        maxCarryLevel = 1;
        lightLevel = 1;

        furnaceScript = GameObject.FindGameObjectWithTag("Furnace").GetComponent<Furnace>();
        moveScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMoviment>();
        collisionsScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerCollisions>();
        anim = GameObject.FindGameObjectWithTag("Player").GetComponentInChildren<Animator>();
        torch = GameObject.FindGameObjectWithTag("Player").GetComponentInChildren<TorchScript>();
    }

    // Update is called once per frame
    void Update()
    {
        torch.lightLevel = lightLevel;
        text[3].text = furnaceScript.fuel.ToString();

        if(furnaceScript.fuel >= 200)
        {
            controller.winGame = true;
        }

    }



    //void call buttons
    public void UpSpeedMod()
    {
        switch (speedModLevel)
        {
            case 1:
                if (furnaceScript.fuel >= 4)
                {
                    furnaceScript.fuel -= 4;
                    speedModLevel = 2;
                    moveScript.speedMod = 1.25f;
                    text[0].text = "Level up your movement speed.\n 1.25-> 1.35";
                    textButton[0].text = "6";
                }
                break;
            case 2:
                if (furnaceScript.fuel >= 6)
                {
                    furnaceScript.fuel -= 6;
                    speedModLevel = 3;
                    moveScript.speedMod = 1.35f;
                    text[0].text = "Level up your movement speed.\n 1.35-> 1.45";
                    textButton[0].text = "9";
                }
                break;
            case 3:
                if (furnaceScript.fuel >= 9)
                {
                    furnaceScript.fuel -= 9;
                    speedModLevel = 4;
                    moveScript.speedMod = 1.45f;
                    text[0].text = "Level up your movement speed.\n 1.35";
                    textButton[0].text = "Max";
                }
                break;            
        }
    }

    public void UpMaxCarryLvl()
    {
        switch (maxCarryLevel)
        {
            case 1:
                if (furnaceScript.fuel >= 4)
                {
                    furnaceScript.fuel -= 4;
                    maxCarryLevel = 2;
                    collisionsScript.maxFuelCarry = 7;
                    text[1].text = "Increased your inventory.\n 7-> 9";
                    textButton[1].text = "6";
                }
                break;
            case 2:
                if (furnaceScript.fuel >= 6)
                {
                    furnaceScript.fuel -= 6;
                    maxCarryLevel = 3;
                    collisionsScript.maxFuelCarry = 9;
                    text[1].text = "Increased your inventory.\n 9-> 12";
                    textButton[1].text = "9";
                }
                break;
            case 3:
                if (furnaceScript.fuel >= 9)
                {
                    furnaceScript.fuel -= 9;
                    maxCarryLevel = 4;
                    collisionsScript.maxFuelCarry = 12;
                    text[1].text = "Increased your inventory. 12";
                    textButton[1].text = "Max";
                }
                break;
        }
    }

    public void UpLightTime()
    {
        switch (lightLevel)
        {
            case 1:
                if (furnaceScript.fuel >= 4)
                {
                    furnaceScript.fuel -= 4;
                    lightLevel = 2;
                    torch.maxTime = 35;
                    text[2].text = "Level up your torch time.\n 35s-> 45s";
                    textButton[2].text = "6";
                }
                break;
            case 2:
                if (furnaceScript.fuel >= 6)
                {
                    furnaceScript.fuel -= 6;
                    lightLevel = 3;
                    torch.maxTime = 45;
                    text[2].text = "Level up your torch time.\n 45s-> 55s";
                    textButton[2].text = "9";
                }
                break;
            case 3:
                if (furnaceScript.fuel >= 9)
                {
                    furnaceScript.fuel -= 9;
                    lightLevel = 4;
                    torch.maxTime = 55;
                    text[2].text = "Level up your torch time.\n 55s";
                    textButton[2].text = "Max";
                }
                break;
        }
    }

    public void BuyLamp()
    {
        if(furnaceScript.fuel >= 50)
        {
            furnaceScript.fuel -= 50;
            anim.SetBool("lampBuy",true);
            torch.lamp = true;
            textButton[3].text = "Sold";
        }
    }
}