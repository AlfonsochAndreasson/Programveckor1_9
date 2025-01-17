using UnityEngine;

public class MoveAndStop : MonoBehaviour
{
    public float moveSpeed = 5f;  // Hastighet p� r�relse
    public float slowSpeed = 2f;  // L�ngsam hastighet n�r shift h�lls ned
    public float jumpForce = 5f;  // Hopph�jd
    private Rigidbody rb;
    private bool isMoving = false; // Kontrollera om r�relsen �r p� eller inte

    void Start()
    {
        // H�mta Rigidbody-komponenten
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Kontrollera om v�nster eller h�ger tangent h�lls ned
        float horizontalInput = Input.GetAxis("Horizontal");

        // Om n�gon tangent �r nedtryckt, r�r objektet
        if (horizontalInput != 0)
        {
            isMoving = true; // Objektet ska r�ra sig
        }
        else
        {
            isMoving = false; // Objektet ska inte r�ra sig
        }

        // Om r�relse �r aktiv (tangent nedtryckt)
        if (isMoving)
        {
            // Kolla om Shift �r nedtryckt f�r l�ngsam r�relse
            float currentMoveSpeed = moveSpeed;
            if (Input.GetKey(KeyCode.LeftShift)) // Om Shift h�lls ned, g� l�ngsamt
            {
                currentMoveSpeed = slowSpeed;
            }

            // Applicera r�relse baserat p� anv�ndarens input
            rb.velocity = new Vector3(horizontalInput * currentMoveSpeed, rb.velocity.y, 0);
        }
        else
        {
            // Om inte n�gon tangent �r nedtryckt, stoppa objektet
            rb.velocity = new Vector3(0, rb.velocity.y, 0); // Stoppa r�relsen
        }

        // Hoppa n�r Space �r nedtryckt
        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded())
        {
            Jump();
        }
    }

    // Metod f�r att hoppa
    void Jump()
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }

    // Kollar om objektet �r p� marken
    bool IsGrounded()
    {
        return Physics.Raycast(transform.position, Vector3.down, 1f);
    }
}
