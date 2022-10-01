using UnityEngine;

public class ScBg : MonoBehaviour
{
    public float speed;
    private Vector3 vertical;

    void Start()
    {
        vertical = transform.position;
    }

    public void Move(Vector3 position)
    {
        vertical = position;
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, vertical, speed * Time.deltaTime);
    }

}

