using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shadow : MonoBehaviour
{
    public GameObject Spring;
    public GameObject Player;
    float count = 0.0f;
    Vector3 st;
    Vector3 ed;
    Vector3 ctrl;
    private void Update()
    {
        st = Spring.GetComponent<Spring>().startPoint;
        ed = Spring.GetComponent<Spring>().endPoint;
        ctrl = Spring.GetComponent<Spring>().controlPoint;
        ctrl.y = st.y;
        updatePosition();
    }
    void updatePosition()
    { 
        if (Spring.GetComponent<Spring>().HitSpring == true)
        {
            if (count < 1.0f)
            {
                count += 1.0f * Time.deltaTime;


                Vector3 m1 = Vector3.Lerp(st, ctrl, count);
                Vector3 m2 = Vector3.Lerp(ctrl, ed, count);
                gameObject.transform.position = Vector3.Lerp(m1, m2, count);

            }
        }
        else
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = Player.GetComponent<Rigidbody2D>().velocity;
        }
       
    }
}
