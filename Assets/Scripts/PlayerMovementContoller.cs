using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementContoller : MonoBehaviour
{
    public float speed = 10.0f;
    private Rigidbody2D rigidbody;
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        
        float v = Input.GetAxis("Vertical");

        Vector2 dir = new Vector2(h, v);
        rigidbody.velocity = dir.normalized * speed;

        GetComponent<Animator>().SetBool("FlyingLeft", h < 0);
        GetComponent<Animator>().SetBool("FlyingTop", h > 0);
        GetComponent<Animator>().SetBool("isFlyingRight", h > 0);

    }
}
