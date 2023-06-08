using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D u_RigidBody2D;
    private float pr_Scalar = 1.2f;

    private void OnEnable()
    {
        InputEvents.MoveUp += MoveUp;
        InputEvents.MoveDown += MoveDown;
        InputEvents.MoveLeft += MoveLeft;
        InputEvents.MoveRight += MoveRight;

        InputEvents.MoveUpLeft += MoveUpLeft;
        InputEvents.MoveUpRight += MoveUpRight;
        InputEvents.MoveDownLeft += MoveDownLeft;
        InputEvents.MoveDownRight += MoveDownRight;

        InputEvents.MoveStop += MoveStop;
    }

    private void OnDisable()
    {
        InputEvents.MoveUp -= MoveUp;
        InputEvents.MoveDown -= MoveDown;
        InputEvents.MoveLeft -= MoveLeft;
        InputEvents.MoveRight -= MoveRight;

        InputEvents.MoveUpLeft -= MoveUpLeft;
        InputEvents.MoveUpRight -= MoveUpRight;
        InputEvents.MoveDownLeft -= MoveDownLeft;
        InputEvents.MoveDownRight -= MoveDownRight;

        InputEvents.MoveStop -= MoveStop;
    }

    private void MoveStop()
    {
        u_RigidBody2D.velocity = Vector2.zero;
    }

    private void MoveDownRight()
    {
        u_RigidBody2D.velocity = new Vector2(0.72f * pr_Scalar, -0.72f * pr_Scalar);
    }

    private void MoveDownLeft()
    {
        u_RigidBody2D.velocity = new Vector2(-0.72f * pr_Scalar, -0.72f * pr_Scalar);
    }

    private void MoveUpRight()
    {
        u_RigidBody2D.velocity = new Vector2(0.72f * pr_Scalar, 0.72f * pr_Scalar);
    }

    private void MoveUpLeft()
    {
        u_RigidBody2D.velocity = new Vector2(-0.72f * pr_Scalar, 0.72f * pr_Scalar);
    }

    private void MoveRight()
    {
        u_RigidBody2D.velocity = new Vector2(1 * pr_Scalar, 0 * pr_Scalar);
    }

    private void MoveLeft()
    {
        u_RigidBody2D.velocity = new Vector2(-1 * pr_Scalar, 0 * pr_Scalar);
    }

    private void MoveDown()
    {
        u_RigidBody2D.velocity = new Vector2(0 * pr_Scalar, -1 * pr_Scalar);
    }

    private void MoveUp()
    {
        u_RigidBody2D.velocity = new Vector2(0 * pr_Scalar, 1 * pr_Scalar);
    }

    void Awake()
    {
        u_RigidBody2D = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>();
    }
}
