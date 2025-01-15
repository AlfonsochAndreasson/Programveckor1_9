using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChoiceSystem : MonoBehaviour
{
    
    public void OnOption1Selected()
    {
        SceneManager.LoadScene("YesScene");
    }

    public void OnOption2Selected()
    {
        SceneManager.LoadScene("NoScene");
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
