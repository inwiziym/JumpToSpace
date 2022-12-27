using UnityEngine;
using UnityEngine.UI;
public class Move : MonoBehaviour
{
    public static Move instance;
    public Rigidbody2D rb;
    public float speed;

    public GameObject Player;
    private float horizontalSpeed;
    private bool leftMove;
    private bool rightMove;

    public Text TextInfo;

    float horizontal;

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
        if (Application.platform == RuntimePlatform.Android)
        {
            //AccelerationMove();
        }
    }

    public void AccelerationMove()
    {
        if (Application.platform == RuntimePlatform.Android)    // если платформа Андроид
        {
            speed = Input.acceleration.x;                  // то подключаем акселерометр по оси х
        }

        if (Input.acceleration.x < -0.1f)                           // если наклон акселерометра меньше нуля
        {
            Player.transform.localScale = new Vector3(-1f, 1f, 1f);
            TextInfo.text = ("Left");
        }

        if (Input.acceleration.x > -0.1f)                           // если наклон акселерометра больше нуля
        {
            Player.transform.localScale = new Vector3(1f, 1f, 1f);
            TextInfo.text = ("Right");
        }

        rb.velocity = new Vector2(Input.acceleration.x * 10f, rb.velocity.y);     //  добавляем силу к акселерометру, чтоб он не просто разворачивался в разные стороны
    }
}
