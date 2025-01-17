using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerhealth : MonoBehaviour
{
    public int health;
    public int maxHealth = 4;




    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
    }

    public void TakeDamage(int amount)
    {
        health -= amount;
        if(health <= 0)
        {
            SceneManager.LoadScene(3);
        }
    }




    // Update is called once per frame
    void Update()
    {
        
    }
}
