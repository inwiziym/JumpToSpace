using UnityEngine;

public class EndCam : MonoBehaviour
{
    void Update()
    {
        AntiExitPos();
    }

    void AntiExitPos()
    {
        Vector3 cameraToObject = transform.position - Camera.main.transform.position;
        float distance = -Vector3.Project(cameraToObject, Camera.main.transform.forward).y;
        Vector3 leftBot = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, distance));
        Vector3 rightTop = Camera.main.ViewportToWorldPoint(new Vector3(1, 1, distance));

        float x_left = leftBot.x;
        float x_right = rightTop.x;
       
        Vector3 clampedPos = transform.position;
        clampedPos.x = Mathf.Clamp(clampedPos.x, x_left, x_right);
        transform.position = clampedPos;
    }
}
