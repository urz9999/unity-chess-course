using UnityEngine;

// This is the interface that dictate how a piece move, 
// so every piece of the board must have a script that inherit from this interface
internal interface IObjectTweener
{
	void MoveTo(Transform transform, Vector3 targetPosition);
}