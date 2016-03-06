using UnityEngine;
using System.Collections;

public class movingRight : MonoBehaviour {

    public float moveSpeed = 5;

    GameObject gb;
    Rigidbody rb;

    void Start()
    {
        gb = GameObject.FindGameObjectWithTag("Player");
        rb = gb.GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(moveSpeed, 0);
    }
}
