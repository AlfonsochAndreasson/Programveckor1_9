using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testing : MonoBehaviour
{
    public Stealth stealthScript;
    public Status playerScript;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if( playerScript.isplayerHiding == true)
        {
            print("brainrot");
        }
    }
}
