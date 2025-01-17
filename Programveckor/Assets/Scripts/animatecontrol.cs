using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animatecontrol : MonoBehaviour
{

    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
       


        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A))
        {
            anim.Play("Orphan walk_Clip");
        }
        else
        {
            anim.Play("Orphan idle_Clip");
        }



    }
}
