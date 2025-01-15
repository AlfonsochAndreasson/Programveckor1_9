using UnityEngine;

public class Slow : MonoBehaviour
{
    public float normalSpeed = 5f;      // Normal rörelsehastighet
    public float slowSpeed = 0.01f;      // Hastighet när C hålls ned för långsam rörelse
    private float currentSpeed;         // Aktuell hastighet som används för att röra objektet

    void Update()
    {
        // Kontrollera om C-tangenten är nedtryckt
        if (Input.GetKey(KeyCode.C))
        {
            currentSpeed = slowSpeed;  // Om C hålls ned, sätt hastigheten till långsam
        }
        else
        {
            currentSpeed = normalSpeed;  // Om C inte hålls ned, sätt hastigheten till normal
        }

        // Hämta rörelseingång från tangentbordet (WASD eller piltangenter)
        float moveDirectionX = Input.GetAxis("Horizontal");  // A/D eller vänster/höger piltangenter
        float moveDirectionZ = Input.GetAxis("Vertical");    // W/S eller upp/ned piltangenter

        // Skapa rörelsevektor
        Vector3 move = new Vector3(moveDirectionX, 0, moveDirectionZ);

        // Flytta objektet med den aktuella hastigheten
        transform.Translate(move * currentSpeed * Time.deltaTime);
    }
}
