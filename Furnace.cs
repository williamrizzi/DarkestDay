using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Furnace : MonoBehaviour
{

    public int fuel;
    public int fuelToWin;

    // Start is called before the first frame update
    void Start()
    {
        fuel = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(fuel == fuelToWin)
        {
            //Condição de vitória do jogo;
        }
    }

    public void RoundFuelConsume(int round)
    {
        if(round <= 5)
        {
            if(fuel >= 5)
            {
                fuel -= 5;
            }
            else
            {
                //Gameover
            }            
        }
        else if(round >= 6 && round <= 10)
        {
            if (fuel >= 7)
            {
                fuel -= 7;
            }
            else
            {
                //Gameover
            }
        }

        else if (round >= 11)
        {
            if (fuel >= 12)
            {
                fuel -= 12;
            }
            else
            {
                //Gameover
            }
        }
    }
}
