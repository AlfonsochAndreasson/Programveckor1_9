using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goodend : MonoBehaviour
{

    private bool isNeardoor;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isNeardoor == true && Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene(5);
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {


        isNeardoor = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        isNeardoor = false;
    }

}
