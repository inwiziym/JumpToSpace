using UnityEngine;

public class Move : MonoBehaviour
{
    public static Move instance;
    public Rigidbody2D rb;
    public float speed;

    public GameObject Player;
    private float horizontalSpeed;
    private bool leftMove;
    private bool rightMove;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        leftMove = false;
        rightMove = false;

        if(instance == null)
        {
            instance = this;
        }
    }
    //else button left click
    public void DownLeftMove()
    {
        Player.transform.localScale = new Vector3(-1f, 1f, 1f);
        leftMove = true;
    }
    public void UpLeftMove()
    {
        leftMove = false;
    }
    //else button right click
    public void DownRightMove()
    {
        Player.transform.localScale = new Vector3(1f, 1f, 1f);
        rightMove = true;
    }
    public void UpRightMove()
    {
        rightMove = false;
    }


    void Update()
    {        
        Movement();
    }
    //Movement player
    private void Movement()
    {
        if (leftMove)
        {
            horizontalSpeed = -speed;
        }
        else if (rightMove)
        {
            horizontalSpeed = speed;
        }
        else
        {
            horizontalSpeed = 0f;
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontalSpeed, rb.velocity.y);
    }

}
