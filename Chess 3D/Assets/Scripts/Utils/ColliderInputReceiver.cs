using UnityEngine;

public class ColliderInputReciever : InputReciever
{
    private Vector3 clickPosition;
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // the left button
        {
            // We launch a ray from our point of view to the point clicked in the UI space
            // If the ray in reaching the target position collide with the object linked to this script than the condition is true
            // And we save the hit point in the clickPosition variable
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                // We save the position in the class variable and then we call the method to process the click
                // For all the click handler associated to the object linked to this script
                clickPosition = hit.point;
                OnInputRecieved();
            }
        }
    }

    public override void OnInputRecieved()
    {
        foreach (var handler in inputHandlers)
        {
            handler.ProcessInput(clickPosition, null, null);
        }
    }
}