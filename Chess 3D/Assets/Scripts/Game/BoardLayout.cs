using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

// This is an helper class to manage all the characteristics of the game based on the board we have, the pieces, the colors and so on
public enum TeamColor
{
    Black, White
}

public enum PieceType
{
    Pawn, Bishop, Knight, Rook, Queen, King
}

[CreateAssetMenu(menuName = "Scriptable Objects/Board/Layout")] // This is a way to define a new object in the context menu of the editor (basically you are defining a script template)
public class BoardLayout : ScriptableObject
{
    [Serializable]
    private class BoardSquareSetup
    {
        public Vector2Int position;
        public PieceType pieceType;
        public TeamColors teamColor;
    }

    [SerializeField] private BoardSquareSetup[] boardSquares;

    public int GetPiecesCount()
    {
        return boardSquares.Length;
    }


    public Vector2Int GetSquareCoordsAtIndex(int index)
    {
        return new Vector2Int(boardSquares[index].position.x - 1, boardSquares[index].position.y - 1);
    }
    public string GetSquarePieceNameAtIndex(int index)
    {
        return boardSquares[index].pieceType.ToString();
    }
    public TeamColors GetSquareTeamColorAtIndex(int index)
    {
        return boardSquares[index].teamColor;
    }

}