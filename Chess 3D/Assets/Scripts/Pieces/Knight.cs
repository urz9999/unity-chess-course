using System.Collections.Generic;
using UnityEngine;

public class Knight : Piece
{
	Vector2Int[] offsets = new Vector2Int[]
	{
		// This is interesting you are defining the offset a Knight can move to 
		// imaging a starting point which is the occupied square vector in the grid system 
		// which is inherited from the pice class
		new Vector2Int(2, 1),
		new Vector2Int(2, -1),
		new Vector2Int(1, 2),
		new Vector2Int(1, -2),
		new Vector2Int(-2, 1),
		new Vector2Int(-2, -1),
		new Vector2Int(-1, 2),
		new Vector2Int(-1, -2),
	};

	public override List<Vector2Int> SelectAvaliableSquares()
	{
		avaliableMoves.Clear();

		for (int i = 0; i < offsets.Length; i++)
		{
			Vector2Int nextCoords = occupiedSquare + offsets[i];
			Piece piece = board.GetPieceOnSquare(nextCoords);
			if (!board.CheckIfCoordinatesAreOnBoard(nextCoords))
				continue;
			if (piece == null || !piece.IsFromSameTeam(this))
				TryToAddMove(nextCoords);
		}
		return avaliableMoves;
	}
}