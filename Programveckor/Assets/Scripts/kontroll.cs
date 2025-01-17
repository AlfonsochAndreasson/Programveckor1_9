using UnityEngine;

public class MoveAndStop : MonoBehaviour
{
    public float moveSpeed = 5f;  // Hastighet på rörelse
    public float slowSpeed = 2f;  // Långsam hastighet när shift hålls ned
    public float jumpForce = 5f;  // Hopphöjd
    private Rigidbody rb;
    private bool isMoving = false; // Kontrollera om rörelsen är på eller inte

    void Start()
    {
        // Hämta Rigidbody-komponenten
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Kontrollera om vänster eller höger tangent hålls ned
        float horizontalInput = Input.GetAxis("Horizontal");

        // Om någon tangent är nedtryckt, rör objektet
        if (horizontalInput != 0)
        {
            isMoving = true; // Objektet ska röra sig
        }
        else
        {
            isMoving = false; // Objektet ska inte röra sig
        }

        // Om rörelse är aktiv (tangent nedtryckt)
        if (isMoving)
        {
            // Kolla om Shift är nedtryckt för långsam rörelse
            float currentMoveSpeed = moveSpeed;
            if (Input.GetKey(KeyCode.LeftShift)) // Om Shift hålls ned, gå långsamt
            {
                currentMoveSpeed = slowSpeed;
            }

            // Applicera rörelse baserat på användarens input
            rb.velocity = new Vector3(horizontalInput * currentMoveSpeed, rb.velocity.y, 0);
        }
        else
        {
            // Om inte någon tangent är nedtryckt, stoppa objektet
            rb.velocity = new Vector3(0, rb.velocity.y, 0); // Stoppa rörelsen
        }

        // Hoppa när Space är nedtryckt
        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded())
        {
            Jump();
        }
    }

    // Metod för att hoppa
    void Jump()
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }

    // Kollar om objektet är på marken
    bool IsGrounded()
    {
        return Physics.Raycast(transform.position, Vector3.down, 1f);
    }
}
