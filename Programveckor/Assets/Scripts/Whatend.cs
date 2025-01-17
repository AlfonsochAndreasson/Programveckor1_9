using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Whatend : MonoBehaviour
{

   private bool isNearN;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isNearN == true && Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene(4);
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        
       
        isNearN = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        isNearN = false;
    }




}
