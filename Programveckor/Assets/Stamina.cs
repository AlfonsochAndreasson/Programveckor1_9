using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Stamina : MonoBehaviour
{

    float StaminaS = 10;
    public bool maxStamina;

    public PlayerMovement playerM;

    // Start is called before the first frame update
    void Start()
    {
        StaminaS = 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (StaminaS > 10)
        {
            maxStamina = true;
        }
        else
        {
            maxStamina = false;
        }
        if (playerM.isRunning == true)
        {
            Staminacheck();
            StaminaS -= Time.deltaTime;
            
        }
        
       
    }
    void Staminacheck()
    {
        if (StaminaS < 0 && playerM.isRunning == true)
        {
            playerM.isRunning = false;
        }
    }
}
