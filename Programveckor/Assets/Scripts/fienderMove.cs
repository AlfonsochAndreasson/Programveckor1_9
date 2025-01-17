using UnityEngine;

public class MoveAroundScreen : MonoBehaviour
{
    public float speed = 30f;  // Hastighet f�r objektets r�relse
    private Vector3 startPosition;

    void Start()
    {
        // Sparar startpositionen s� att vi kan �terg� till den om vi vill.
        startPosition = transform.position;
    }

    void Update()
    {
        // Ber�kna r�relsen l�ngs X- och Y-axeln baserat p� tiden och hastigheten.
        float xMovement = Mathf.PingPong(Time.time * speed, Screen.width);
        float yMovement = Mathf.PingPong(Time.time * speed, Screen.height);

        // Konvertera fr�n sk�rmkoordinater till v�rldens koordinater.
        Vector3 newPosition = Camera.main.ScreenToWorldPoint(new Vector3(xMovement, yMovement, Camera.main.nearClipPlane));

        // Uppdatera objektets position.
        transform.position = newPosition;
    }
}
