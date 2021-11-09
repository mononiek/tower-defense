using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 10f;

    private int Health;
    public int starthealth = 50;

    public int value = 50;

    private Transform target;
    private int wavepointIndex = 0;

    void Start()
    {
        target = Waypoints.points[0];
        Health = starthealth;
    }

    public void TakeDamage (int amount)
    {
        Health -= amount;

        if (Health <= 0)
        {
            Die();
        }
    }

    void Die ()
    {
        PlayerStats.Money += value;
        Destroy(gameObject);
    }

    void Update()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

        if (Vector3.Distance(transform.position, target.position) <= 0.025f)
        {
            GetNextWaypoint();
        }
    }

    void GetNextWaypoint()
    {
        if (wavepointIndex >= Waypoints.points.Length - 1)
        {
            EndPad();
            return;
        }
        
        wavepointIndex++;
        target = Waypoints.points[wavepointIndex];
    }

    void EndPad ()
    {
        PlayerStats.Lives--;
        Destroy(gameObject);
    }
}
