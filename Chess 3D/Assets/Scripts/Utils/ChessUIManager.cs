using UnityEngine;
using UnityEngine.UI;

// This class is a simple controller attached to the UI canvas, it manages the show/hide value of the UI Panel based on two methods that represents
// Two possible state conditions
public class ChessUIManager : MonoBehaviour
{
	[SerializeField] private GameObject UIParent;
	[SerializeField] private Button restartButton;
	[SerializeField] private Text finishText;

	internal void HideUI()
	{
		UIParent.SetActive(false);
	}

	internal void OnGameFinished(string winner)
	{
		UIParent.SetActive(true);
		finishText.text = string.Format("{0} won", winner);
	}
}