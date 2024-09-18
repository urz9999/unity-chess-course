using UnityEngine;
using UnityEngine.UI;

// This is a simple UI button done in the legacy input system of unity just to show how to create a button via code
// In newer versions this complexity is hidden, still this way you have much more control in what you can do in a click event
[RequireComponent(typeof(UIInputReciever))]
public class UIButton : Button
{
	private InputReciever reciever;
	protected override void Awake()
	{
		reciever = GetComponent<UIInputReciever>();
		onClick.AddListener(() => reciever.OnInputRecieved());
	}
}