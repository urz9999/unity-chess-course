using UnityEngine;

public abstract class InputReciever : MonoBehaviour
{
    // By implementing this abstract class the Collider input receiver inherit all the handler associated
    protected IInputHandler[] inputHandlers;

    public abstract void OnInputRecieved();

    private void Awake()
    {
        inputHandlers = GetComponents<IInputHandler>();
    }
}