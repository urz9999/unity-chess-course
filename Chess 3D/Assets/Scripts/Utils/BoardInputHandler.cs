using System;
using UnityEngine;

[RequireComponent(typeof(Board))]
public class BoardInputHandler : MonoBehaviour, IInputHandler
{
    private Board board;

    private void Awake()
    {
        board = GetComponent<Board>();
    }

    public void ProcessInput(Vector3 inputPosition, GameObject selectedObject, Action onClick)
    {
        // We ask the board to do something based on the square selected by the mouse click
        // This is possible because in the board object we have interpreted the game space on the board grid
        // You can check this in the board class
        board.OnSquareSelected(inputPosition);
    }
}