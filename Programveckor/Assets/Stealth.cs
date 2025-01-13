using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stealth : MonoBehaviour
{
    public PlayerMovement playerScript;

   public bool isHiding = false;
    bool isNear = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isNear == true && Input.GetKeyDown(KeyCode.E))
        {
            playerScript.isplayerHiding = true;
            
        }
        if (playerScript.isplayerHiding == true && Input.GetKeyDown(KeyCode.E))
        {
            isHiding = false;
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isNear = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        isNear = false;
        playerScript.isplayerHiding = false;
    }
}
