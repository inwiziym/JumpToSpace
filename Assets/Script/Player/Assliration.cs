using UnityEngine;
public class Assliration : MonoBehaviour
{
    public GameObject Player;
    public Rigidbody2D rb;

    public void FixedUpdate()
    {
        rb.velocity = new Vector2(Move.horizontalSpeed, rb.velocity.y);

        if (Input.acceleration.x < -0.1f)
        {
            Player.transform.localScale = new Vector3(-1f, 1f, 1f);
        }

        if (Input.acceleration.x > 0.1f)
        {
            Player.transform.localScale = new Vector3(1f, 1f, 1f);
        }
        rb.velocity = new Vector2(Input.acceleration.x * 10f, rb.velocity.y);
    }
}
