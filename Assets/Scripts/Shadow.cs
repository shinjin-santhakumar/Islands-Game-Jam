using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shadow : MonoBehaviour
{
    public GameObject Spring;
    public GameObject Player;
    public GameObject Listener;
    
    Vector3 st;
    Vector3 ed;
    Vector3 ctrl;
    float fl;
    private void Awake()
    {
        fl = transform.position.y;
    }
    private void Update()
    {
        st = Spring.GetComponent<Spring>().startPoint;
        ed = Spring.GetComponent<Spring>().endPoint;
        ctrl = Spring.GetComponent<Spring>().controlPoint;
        st.y = 
        ed.y = transform.position.y;
        ctrl.y = st.y;
        updatePosition();
    }
    void updatePosition()
    { 
        if (Spring.GetComponent<Spring>().HitSpring == true && Listener.GetComponent<ResetButton>().hit_Reset == false)
        {
            if (Spring.GetComponent<Spring>().count < 1.0f)
            {
                Spring.GetComponent<Spring>().count += 1.0f * Time.deltaTime;


                Vector3 m1 = Vector3.Lerp(st, ctrl, Spring.GetComponent<Spring>().count);
                Vector3 m2 = Vector3.Lerp(ctrl, ed, Spring.GetComponent<Spring>().count);
                gameObject.transform.position = Vector3.Lerp(m1, m2, Spring.GetComponent<Spring>().count);

            }
        }
        else
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = Player.GetComponent<Rigidbody2D>().velocity;
        }
       
    }
}
