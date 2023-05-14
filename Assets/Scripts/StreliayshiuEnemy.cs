using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StreliayshiuEnemy : MonoBehaviour
{
    private float timeBtwShots;
    public float StartTimeBtwShots;

    public GameObject projectile;

    public Transform player;

    void Start()
    {
      player = GameObject.FindGameObjectWithTag("Player").transform;

      timeBtwShots = StartTimeBtwShots;
    }

    void Update()
    {
      if (timeBtwShots <=0)
      {
        Instantiate(projectile, player.position, Quaternion.identity);
        timeBtwShots = StartTimeBtwShots;
      }
      else
      {
        timeBtwShots -= Time.deltaTime;
      }
    }
}
