using UnityEngine;

public class BallController : MonoBehaviour {

    private Rigidbody2D rigid2D;
    private SpriteRenderer renderer;

    private float walkSpeed = 30.0f;
    private float threshold = 0.1f;

    public Sprite[] sprites;

    // Use this for initialization
    void Start () {
        rigid2D = this.GetComponent<Rigidbody2D>();
        renderer = this.GetComponent<SpriteRenderer>();

        int rand = Random.Range(0, sprites.Length);
        renderer.sprite = sprites[rand];
    }

    // Update is called once per frame
    void Update () {
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


        Vector2 vec2 = new Vector2(keyX * this.walkSpeed, keyY * this.walkSpeed);
        this.rigid2D.AddForce(vec2);
    }
}
