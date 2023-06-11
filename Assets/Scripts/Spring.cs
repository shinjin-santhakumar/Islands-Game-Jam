using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spring : MonoBehaviour
{
    public GameObject Player;
    public GameObject PlayerChild;

    public GameObject Listener;
    public bool HitSpring;
    public Vector3 startPoint;
    public Vector3 endPoint;
    public Vector3 controlPoint;
    public Vector3 ModifyLenOfJump;
    public Vector3 ModifyArcControlPoint;
    public Transform ArcPoint;
    public float count = 0.0f;
    bool right = false;


    // Start is called before the first frame update

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("PlayerChild"))
        {
            Player.GetComponent<BoxCollider2D>().enabled = false;
            PlayerChild.GetComponent<BoxCollider2D>().enabled = false;
            //right velocity
            if (Player.GetComponent<Rigidbody2D>().velocity.x > .01f)
            {
                
                startPoint = Player.transform.position;
                endPoint = Player.transform.position + ModifyLenOfJump;
                controlPoint = startPoint + ModifyArcControlPoint;
                right = true;
            }
            //left velocity
            else if (Player.GetComponent<Rigidbody2D>().velocity.x < -.01f)
            {
               
                startPoint = Player.transform.position;
                endPoint = Player.transform.position - ModifyLenOfJump;
                controlPoint.y = Player.transform.position.y + ModifyArcControlPoint.y;
                controlPoint.x = Player.transform.position.x - ModifyArcControlPoint.x; 
            }
            HitSpring = true;

            //Play spring sink animation, remove collider
            GetComponent<Animator>().SetTrigger("ramp_sink");
            GetComponent<BoxCollider2D>().enabled = false;
            
        }

       
    }
    private void Update()
    {
        if (HitSpring == true && Listener.GetComponent<ResetButton>().hit_Reset == false)
        {
            Debug.Log("running lerp");
            
            if (count < 1.0f)
            {
                Debug.Log("inside lerp");
                count += 1.0f * Time.deltaTime;

                Vector3 m1 = Vector3.Lerp(startPoint, controlPoint, count);
                Vector3 m2 = Vector3.Lerp(controlPoint, endPoint, count);
                Player.transform.position = Vector3.Lerp(m1, m2, count);

            }
            if (Player.transform.position.x >= endPoint.x && right == true)
            {
                HitSpring = false;
                Player.GetComponent<BoxCollider2D>().enabled = true;
                PlayerChild.GetComponent<BoxCollider2D>().enabled = true;
                right = false;
                count = 0;
            }
            else if (Player.transform.position.x <= endPoint.x && right == false)
            {
                HitSpring = false;
                Player.GetComponent<BoxCollider2D>().enabled = true;
                PlayerChild.GetComponent<BoxCollider2D>().enabled = true;
                count = 0;
            }

        }
    }
}
