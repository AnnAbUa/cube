using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
  public float speed;
  public float jumpForce;
  private float moveInput;
  private int tryCount;

  private Rigidbody2D rb;

  public Joystick joystick;

  private bool facingRight = true;

  public bool isGrounded;
  public Transform feetPos;
  public float checkRadius;
  public LayerMask whatIsGround;

  [SerializeField] InterAd adTransition;

  private void Start()
  {
    rb = GetComponent<Rigidbody2D>();
  }

  private void FixedUpdate()
  {
      moveInput = joystick.Horizontal;
      rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
      if(!facingRight && moveInput > 0)
      {
        Flip();
      }
      else if(facingRight && moveInput < 0)
      {
        Flip();
      }
  }

  void Update()
  {
    isGrounded = Physics2D.OverlapCircle(feetPos.position, checkRadius, whatIsGround);
  }

    public void OnJumpButtonDown()
    {
      if(isGrounded == true)
      {
        rb.velocity = Vector2.up * jumpForce;
      }
    }

  void Flip()
    {
      facingRight = !facingRight;
      Vector3 Scaler = transform.localScale;
      Scaler.x *= -1;
      transform.localScale = Scaler;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
      if (collision.gameObject.name.Equals("Platform"))
      {
        this.transform.parent = collision.transform;
      }
    }

     private void OnCollisionExit2D(Collision2D collision)
    {
      if (collision.gameObject.name.Equals("Platform"))
      {
        this.transform.parent = null;
      }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
      if (collision.tag.Equals("Coin"))
      {
        CoinCollect.CoinCount += 1;
        Destroy(collision.gameObject);
      }
    }
}