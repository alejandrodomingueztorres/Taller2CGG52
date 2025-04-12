using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovePlayer : MonoBehaviour
{
    public GameObject Bullet1; 
    public float moveSpeed = 2f;
    public float jumpForce = 2f;

    private Rigidbody2D rb;
    private bool isGrounded;
    private Animator Animator;
    private float LastShoot;
    private int Health = 5;
    public Text textoVida;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Animator = GetComponent<Animator>();
        tVida();


        if (rb == null)
        {
            rb = gameObject.AddComponent<Rigidbody2D>();
            rb.gravityScale = 3f;
            rb.freezeRotation = true;
        }


        if (GetComponent<Collider2D>() == null)
        {
            BoxCollider2D collider = gameObject.AddComponent<BoxCollider2D>();
            collider.size = new Vector2(1f, 1f);
        }
    }
    // Update is called once per frame
    void Update()
    {

        float horizontal = Input.GetAxis("Horizontal");
        if (horizontal < 0.0f) transform.localScale = new Vector3(-1.0f, 1.0f, 1.0f);
        else if (horizontal > 0.0f) transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
        Animator.SetBool("Running", horizontal != 0.0f);


        Vector2 movement = new Vector2(horizontal * moveSpeed, rb.velocity.y);
        rb.velocity = movement;


        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            isGrounded = false;
        }
        if (Input.GetKey(KeyCode.F) && Time.time > LastShoot + 0.25f)
        {
            Shoot();
            LastShoot = Time.time;
        }
    }

    private void Shoot()
    {
        Vector3 direction;
        if (transform.localScale.x == 1.0f) direction = Vector3.right;
        else direction = Vector3.left;
        GameObject bullet = Instantiate(Bullet1, transform.position + direction * 0.1f, Quaternion.identity);
        bullet.GetComponent<Bullets1Script>().SetDirection(direction);

    }
   

    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
    public void Hit()
    {
        Health = Health - 1;
        if (Health == 0) Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("muerteIns"))
        {
            Health = Health - 100;
            tVida();
        }
    }
    void tVida()
    {
        textoVida.text = Health.ToString();
    }
}

