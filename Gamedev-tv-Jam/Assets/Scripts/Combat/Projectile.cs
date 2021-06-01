using Gamedev.Combat;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private int damage;
    [SerializeField] private float speed;
    public bool goLeft;
    // Update is called once per frame
    void Update()
    {
        if (goLeft) {
            transform.position = new Vector3(transform.position.x - speed, transform.position.y, transform.position.z);
        }
        else
        {
            transform.position = new Vector3(transform.position.x + speed, transform.position.y, transform.position.z);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Health>())
        {
            if (other.tag == "Player") return;
            other.GetComponent<Health>().TakeDamage(damage);
        }
    }
}