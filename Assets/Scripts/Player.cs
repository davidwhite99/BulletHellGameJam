using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] public int startHP;
    int hp;
    [SerializeField] public float bulletCooldown;
    [SerializeField] float bulletTimer;


    void Start()
    {
        hp = startHP;
    }

   
    void Update()
    {
        bulletTimer -= Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bullet" && bulletTimer <= 0)
        {
            hp -= 1;
            print(hp);
            bulletTimer = bulletCooldown;
        }
    }
}
