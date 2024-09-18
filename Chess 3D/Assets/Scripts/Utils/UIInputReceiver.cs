using UnityEngine;
using UnityEngine.Events;

public class UIInputReciever : InputReciever
{
    [SerializeField] UnityEvent onClick;

    public override void OnInputRecieved()
    {
        foreach (var handler in inputHandlers)
        {
            // This is a bit tricky: when you process the input you are defining 
            // a Unity Action which is an anonymous function that calls the invoke method on the Unity event attached to this script
            handler.ProcessInput(Input.mousePosition, gameObject, () => onClick.Invoke());
        }
    }
}