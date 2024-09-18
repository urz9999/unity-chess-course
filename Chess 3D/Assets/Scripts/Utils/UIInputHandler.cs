using System;
using UnityEngine;

public class UIInputHandler : MonoBehaviour, IInputHandler
{
    public void ProcessInput(Vector3 inputPosition, GameObject selectedObject, Action onClick)
    {
        // Just invoke the onClick action
        onClick?.Invoke();
    }
}
