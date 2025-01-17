using UnityEngine;  // Vi anv�nder Unitys bibliotek 
 
public class MoveObject : MonoBehaviour 
{ 
    public float moveSpeed = 5f;  // Best�mmer hastigheten p� r�relsen 
     
    void Update() 
    { 
        // H�mta inmatning fr�n tangentbordet f�r v�nster/h�ger r�relse 
        float horizontalInput = Input.GetAxis("Horizontal"); 
         
        // Flytta objektet beroende p� inmatningen 
        transform.Translate(Vector3.right * horizontalInput * moveSpeed * Time.deltaTime); 
    } 
} 
