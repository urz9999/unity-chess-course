using UnityEngine;

public class InstantTweener : MonoBehaviour, IObjectTweener
{
    // This method just set the object's position to the target position without interpolation (without animaiton in this case)
    public void MoveTo(Transform transform, Vector3 targetPosition)
    {
        transform.position = targetPosition;
    }
}