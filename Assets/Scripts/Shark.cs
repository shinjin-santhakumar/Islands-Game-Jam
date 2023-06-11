using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shark : MonoBehaviour
{
    [SerializeField] private GameObject[] waypoints;
    private int currentWaypointIndex = 0;
    // public GameObject Player;
    [SerializeField] private float speed = 2f;

    private Rigidbody2D rb;
    private SpriteRenderer sr;

    // Update is called once per frame
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }
    private void Update()
    {
        //print(Vector3.Distance(waypoints[currentWaypointIndex].transform.position, transform.position));
        if (Vector3.Distance(waypoints[currentWaypointIndex].transform.position, transform.position) < .1f)
        {
            currentWaypointIndex++;
            sr.flipX = !sr.flipX;
            if (currentWaypointIndex >= waypoints.Length)
            {
                currentWaypointIndex = 0;
            }
        }
        transform.position = Vector2.MoveTowards(transform.position, waypoints[currentWaypointIndex].transform.position, Time.deltaTime * speed);

        // print(rb.velocity.x);
        // if (rb.velocity.x > 0)
        // {
        //     sr.flipX = true;
        // }
        // else
        // {
        //     sr.flipX = false;
        // }
    }

    // private void OnCollisionEnter2D(Collision2D collision)
    // {
    //     Player.GetComponent<BoxCollider2D>().enabled = true;
    // }
}