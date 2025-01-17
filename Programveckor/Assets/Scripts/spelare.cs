using UnityEngine;  // Vi använder Unitys bibliotek 
 
public class MoveObject : MonoBehaviour 
{ 
    public float moveSpeed = 5f;  // Bestämmer hastigheten på rörelsen 
     
    void Update() 
    { 
        // Hämta inmatning från tangentbordet för vänster/höger rörelse 
        float horizontalInput = Input.GetAxis("Horizontal"); 
         
        // Flytta objektet beroende på inmatningen 
        transform.Translate(Vector3.right * horizontalInput * moveSpeed * Time.deltaTime); 
    } 
} 
