using UnityEngine;

public class MoveAroundScreen : MonoBehaviour
{
    public float speed = 30f;  // Hastighet för objektets rörelse
    private Vector3 startPosition;

    void Start()
    {
        // Sparar startpositionen så att vi kan återgå till den om vi vill.
        startPosition = transform.position;
    }

    void Update()
    {
        // Beräkna rörelsen längs X- och Y-axeln baserat på tiden och hastigheten.
        float xMovement = Mathf.PingPong(Time.time * speed, Screen.width);
        float yMovement = Mathf.PingPong(Time.time * speed, Screen.height);

        // Konvertera från skärmkoordinater till världens koordinater.
        Vector3 newPosition = Camera.main.ScreenToWorldPoint(new Vector3(xMovement, yMovement, Camera.main.nearClipPlane));

        // Uppdatera objektets position.
        transform.position = newPosition;
    }
}
