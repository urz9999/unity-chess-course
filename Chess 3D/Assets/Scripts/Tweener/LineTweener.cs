using DG.Tweening;
using UnityEngine;

public class LineTweener : MonoBehaviour, IObjectTweener
{
    [SerializeField] private float movementSpeed = 10;

    public void MoveTo(Transform transform, Vector3 targetPosition)
    {
        // This method moves the piece to the target position by interpolating the current position in time based on the piece speed
        float distance = Vector3.Distance(targetPosition, transform.position);
        transform.DOMove(targetPosition, distance / movementSpeed);
    }
}