using System.Collections.Generic;
using UnityEngine;

public class Bishop : Piece
{
    private Vector2Int[] directions = new Vector2Int[]
    {
        // Imagine these as the direction of the piece in this case al the diagonals
        new Vector2Int(1, 1),
        new Vector2Int(1, -1),
        new Vector2Int(-1, 1),
        new Vector2Int(-1,- 1),
    };
    public override List<Vector2Int> SelectAvaliableSquares()
    {
        avaliableMoves.Clear();
        float range = Board.BOARD_SIZE;
        foreach (var direction in directions)
        {
            for (int i = 1; i <= range; i++)
            {
                Vector2Int nextCoords = occupiedSquare + direction * i;
                Piece piece = board.GetPieceOnSquare(nextCoords);
                if (!board.CheckIfCoordinatesAreOnBoard(nextCoords))
                    break;
                if (piece == null)
                    TryToAddMove(nextCoords);
                else if (!piece.IsFromSameTeam(this))
                {
                    // Here we say that we can move to that square because we can capture the other piece
                    TryToAddMove(nextCoords);
                    break;
                }
                else if (piece.IsFromSameTeam(this))
                    // The square is occupied by a piece of the same team so we can't move on that position
                    break;
            }
        }
        return avaliableMoves;
    }
}