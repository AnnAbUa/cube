using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LadderMovement : MonoBehaviour
{
    public Joystick joystick;
    [SerializeField]

    float speed = 5;

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (joystick.Vertical > 0)
            {
                other.GetComponent<Rigidbody2D>().velocity = new Vector2(0, speed);
            }
        }
        else if (joystick.Vertical < 0)
        {
            other.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -speed);
        }
        else
        {
            other.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        }
    }
}
