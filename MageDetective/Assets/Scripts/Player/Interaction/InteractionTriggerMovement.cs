using UnityEngine;

public class InteractionTriggerMovement : MonoBehaviour
{
    [SerializeField] private BoxCollider2D u_BoxCollider2D;

    private Vector2 pr_UpPositionVector;
    private Vector2 pr_DownPositionVector;
    private Vector2 pr_LeftPositionVector;
    private Vector2 pr_RightPositionVector;

    private void Awake()
    {
        pr_UpPositionVector = new Vector2(0,0);
        pr_DownPositionVector = new Vector2(0,-0.35f);
        pr_LeftPositionVector = new Vector2(-0.2f, -0.15f);
        pr_RightPositionVector = new Vector2(0.2f, -0.15f);
    }

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
    }

    private void MoveDownRight()
    {
        SetOffset(pr_DownPositionVector);
    }

    private void MoveDownLeft()
    {
        SetOffset(pr_DownPositionVector);
    }

    private void MoveUpRight()
    {
        SetOffset(pr_UpPositionVector);
    }

    private void MoveUpLeft()
    {
        SetOffset(pr_UpPositionVector);
    }

    private void MoveRight()
    {
        SetOffset(pr_RightPositionVector);
    }

    private void MoveLeft()
    {
        SetOffset(pr_LeftPositionVector);
    }

    private void MoveDown()
    {
        SetOffset(pr_DownPositionVector);
    }

    private void MoveUp()
    {
        SetOffset(pr_UpPositionVector);
    }

    private void SetOffset(Vector2 pa_OffsetVector)
    {
        u_BoxCollider2D.offset = pa_OffsetVector;
    }
}
