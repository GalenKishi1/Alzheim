using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb2D;

    private float HorizontalMovement = 0f;
    [SerializeField] private float MovementVelocity;
    [Range(0, 0.3f)] [SerializeField] private float Movementsmoothing;
    private Vector3 velocity = Vector3.zero;
    private bool LookingRight = true;


    private void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        HorizontalMovement = Input.GetAxisRaw("Horizontal") * MovementVelocity;
    }

    private void FixedUpdate()
    {
        Move(HorizontalMovement * Time.fixedDeltaTime);
    }

    private void Move(float move)
    {
        Vector3 SpeedTarget = new Vector2(move, rb2D.velocity.y);
        rb2D.velocity = Vector3.SmoothDamp(rb2D.velocity, SpeedTarget, ref velocity, Movementsmoothing);

        if(move>0 && !LookingRight)
        {
            Spin();
        }
        else if(move<0&&LookingRight)
        {
            Spin();
        }
    }

    private void Spin()
    {
        LookingRight = !LookingRight;
        Vector3 escale = transform.localScale;
        escale.x *= -1;
        transform.localScale = escale;
    }
}
