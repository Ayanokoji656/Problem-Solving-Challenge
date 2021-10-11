using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float speed;
    Rigidbody2D PlayerRigidbody;

    // Start is called before the first frame update
    private void Awake()
    {
        PlayerRigidbody = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Tombol A , D
        float horizontal = Input.GetAxisRaw("Horizontal");
        PlayerRigidbody.velocity = new Vector2(speed * horizontal, PlayerRigidbody.velocity.y);

        // Tombol W , S
        float vertical = Input.GetAxisRaw("Vertical");
        PlayerRigidbody.velocity = new Vector2(PlayerRigidbody.velocity.x, speed * vertical);

    }
}
