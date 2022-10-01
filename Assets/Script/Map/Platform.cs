using UnityEngine;

public class Platform : MonoBehaviour
{
    public float Jump;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.y < 0 && collision.collider.name == "player")
        {
            Move.instance.rb.velocity = Vector2.up * Jump;
        }
    }
    public void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.name == "DeadZone")
        {
            float RandX = Random.Range(-2.55f, 2.55f);
            float RandY = transform.position.y + 13f;

            transform.position = new Vector3(RandX, RandY, 0);
        }
    }
}
