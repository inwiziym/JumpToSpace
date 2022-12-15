using UnityEngine;

public class orecopperscope : MonoBehaviour
{
    public Rigidbody2D rb;
    
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "DeadZone")
        {
            Destroy(this.gameObject);
        }
        if (collision.tag == "Player")
        {
            allobjscale.OreCopper++;
            Destroy(this.gameObject);
        }
        if(collision.name == "p_platform")
        {
            rb.constraints= RigidbodyConstraints2D.FreezeAll;
        }
    }
}