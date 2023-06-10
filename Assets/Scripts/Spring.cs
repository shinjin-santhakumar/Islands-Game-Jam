using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spring : MonoBehaviour
{
    public GameObject Player;

    public bool HitSpring;
    public Vector3 startPoint;
    public Vector3 endPoint;
    public Vector3 controlPoint;
    public Vector3 ModifyLenOfJump;
    public Vector3 ModifyArcControlPoint;
    public Transform ArcPoint;
    float count = 0.0f;


    // Start is called before the first frame update

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            HitSpring = true;
            startPoint = Player.transform.position;
            endPoint = Player.transform.position + ModifyLenOfJump;

            Player.GetComponent<BoxCollider2D>().enabled = false;
        }
    }
    private void Update()
    {
        if (HitSpring == true)
        {
            if (Player.GetComponent<Rigidbody2D>().velocity.x > .01f)
            {
                controlPoint = startPoint + ModifyArcControlPoint;
            }
            else
            {
                controlPoint = startPoint + (-ModifyArcControlPoint);
            }
            if (count < 1.0f)
            {
                count += 1.0f * Time.deltaTime;

                Vector3 m1 = Vector3.Lerp(startPoint, controlPoint, count);
                Vector3 m2 = Vector3.Lerp(controlPoint, endPoint, count);
                Player.transform.position = Vector3.Lerp(m1, m2, count);

            }
            if (Player.transform.position.x >= endPoint.x)
            {
                HitSpring = false;
                Player.GetComponent<BoxCollider2D>().enabled = true;
            }
        }
    }
}
