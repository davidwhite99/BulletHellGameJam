using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] public Vector2 velocity;
    [SerializeField] public float speed;
    [SerializeField] public float rotation;

    void Start()
    {
        transform.rotation = Quaternion.Euler(0, 0, rotation);

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(velocity * speed * Time.deltaTime);
    }
}
