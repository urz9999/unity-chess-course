using UnityEngine;
// DG.Tweening is a free 3rd party library that implements some simple programmatic animations
using DG.Tweening;

public class ArcTweener : MonoBehaviour, IObjectTweener
{
    [SerializeField] private float movementSpeed;
    [SerializeField] private float jumpHeight;

    public void MoveTo(Transform transform, Vector3 targetPosition)
    {
        // This allow to simulate a jump along the line of a vector (from target to start position)
        // We manipulate how the jump look by tweeking the serialized fields from the inspector
        float distance = Vector3.Distance(targetPosition, transform.position);
        transform.DOJump(targetPosition, jumpHeight, 1, distance / movementSpeed);
    }
}