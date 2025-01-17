using UnityEngine;

public class Slow : MonoBehaviour
{
    public float normalSpeed = 5f;      // Normal r�relsehastighet
    public float slowSpeed = 0.01f;      // Hastighet n�r C h�lls ned f�r l�ngsam r�relse
    private float currentSpeed;         // Aktuell hastighet som anv�nds f�r att r�ra objektet

    void Update()
    {
        // Kontrollera om C-tangenten �r nedtryckt
        if (Input.GetKey(KeyCode.C))
        {
            currentSpeed = slowSpeed;  // Om C h�lls ned, s�tt hastigheten till l�ngsam
        }
        else
        {
            currentSpeed = normalSpeed;  // Om C inte h�lls ned, s�tt hastigheten till normal
        }

        // H�mta r�relseing�ng fr�n tangentbordet (WASD eller piltangenter)
        float moveDirectionX = Input.GetAxis("Horizontal");  // A/D eller v�nster/h�ger piltangenter
        float moveDirectionZ = Input.GetAxis("Vertical");    // W/S eller upp/ned piltangenter

        // Skapa r�relsevektor
        Vector3 move = new Vector3(moveDirectionX, 0, moveDirectionZ);

        // Flytta objektet med den aktuella hastigheten
        transform.Translate(move * currentSpeed * Time.deltaTime);
    }
}
