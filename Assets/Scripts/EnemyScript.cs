using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public float speed;
    public Vector3[] positions;

    private int currentTarget;

    public GameObject effect;

    private void FixedUpdate()
    {
      transform.position = Vector3.MoveTowards(transform.position, positions[currentTarget], speed);
      if (transform.position == positions[currentTarget])
      {
        if (currentTarget < positions.Length - 1)
        {
          currentTarget++;
        }
        else
        {
          currentTarget = 0;
        }
      }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
      if (collision.gameObject.tag == "Player")
      {
        Debug.Log("Игрок Убит");
      }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
      if (collision.gameObject.tag == "Player")
      {
        Instantiate(effect, transform.position, Quaternion.identity);
        Debug.Log("Enemy Убит");
        Destroy(gameObject, 0.2f);
      }
    }
}
