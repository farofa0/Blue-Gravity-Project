using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Animator))]
public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 1f;

    private Rigidbody2D rigidbody2d;
    private Animator animator;

    void Start()
    {
        rigidbody2d = gameObject.GetComponent<Rigidbody2D>();
        animator = gameObject.GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        // Movement
        var inputVector = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;
        rigidbody2d.MovePosition(rigidbody2d.position + (inputVector * moveSpeed * Time.fixedDeltaTime));

        // Animations
        animator.SetFloat("X", inputVector.x);
        animator.SetFloat("Y", inputVector.y);
    }
}