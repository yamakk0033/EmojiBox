using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {

    private Rigidbody2D rigid2D;
    private float walkSpeed = 30.0f;
    private float maxWalkSpeed = 2.0f;
    private float threshold = 0.2f;

    // Use this for initialization
    void Start () {
        rigid2D = GetComponent<Rigidbody2D>();
    }
    
    // Update is called once per frame
    void Update () {
        //rigid2D.AddForce(transform.right * (Input.acceleration.y * 20.0f));


        int keyX = 0;
        int keyY = 0;
        if (Input.acceleration.x > this.threshold) keyX = 1;
        if (Input.acceleration.x < -this.threshold) keyX = -1;

        if (Input.acceleration.y > this.threshold) keyY = 1;
        if (Input.acceleration.y < -this.threshold) keyY = -1;
        //if (Input.GetKey(KeyCode.RightArrow)) keyX = 1;
        //if (Input.GetKey(KeyCode.LeftArrow)) keyX = -1;
        //if (Input.GetKey(KeyCode.UpArrow)) keyY = 1;
        //if (Input.GetKey(KeyCode.DownArrow)) keyY = -1;


        //float speedx = Mathf.Abs(this.rigid2D.velocity.x);
        //float speedy = Mathf.Abs(this.rigid2D.velocity.y);

        //if (speedx < this.maxWalkSpeed)
        //{
        //    this.rigid2D.AddForce(transform.right * key * this.walkSpeed);
        //}
        //this.rigid2D.AddForce(transform.right * keyX * this.walkSpeed);

        //this.rigid2D.AddForce(transform.right * keyX * this.walkSpeed);
        //this.rigid2D.AddForce(transform.up    * keyY * this.walkSpeed);

        Vector2 vec2 = new Vector2(keyX * this.walkSpeed, keyY * this.walkSpeed);

        this.rigid2D.AddForce(vec2);
    }
}
