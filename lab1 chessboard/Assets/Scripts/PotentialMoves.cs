using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotentialMoves : MonoBehaviour
{
    public Sprite Pawn;
    public Sprite Rook;
    public Sprite Bishop;
    public Sprite Knight;
    public Sprite Queen;
    public Sprite King;

    public bool isPawn;
    public bool isRook;
    public bool isBishop;
    public bool isKnight;
    public bool isQueen;
    public bool isKing;

    //look to see how to make only one bool active
    private void OnValidate()
    {
        
    }
    private void ChangeIcon()
    {

    }
}
