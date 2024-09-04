using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class PotentialMoves : MonoBehaviour
{
    [SerializeField] Sprite[] pieceImages;
    Sprite newSprite;

    public float value = 7.0f;

    public enum ChessTypes
    {
        Rook,
        Pawn,
        Bishop, 
        Knight,
        Queen,
        King,
    }

    public ChessTypes chessTypes;
    public SpriteRenderer spriteRenderer;

    private void OnDrawGizmosSelected()
    {
        
        Gizmos.color = Color.blue;
        //checks which piece is selected and shows potential moves 
        switch (chessTypes)
        {
            case ChessTypes.Pawn:
                newSprite = pieceImages[0];
                gameObject.GetComponent<SpriteRenderer>().sprite = newSprite;
                ForwardMove();
                break;
            case ChessTypes.Rook:
                newSprite = pieceImages[1];
                gameObject.GetComponent<SpriteRenderer>().sprite = newSprite;
                HorizontalMove();
                ForwardMove();
                break;
            case ChessTypes.Bishop:
                newSprite = pieceImages[3];
                gameObject.GetComponent<SpriteRenderer>().sprite = newSprite;
                DiaginalMove();
                break;
            case ChessTypes.King:
                newSprite = pieceImages[5];
                gameObject.GetComponent<SpriteRenderer>().sprite = newSprite;
                ForwardMove();
                DiaginalMove();
                HorizontalMove();
                break;
            case ChessTypes.Queen:
                newSprite = pieceImages[4];
                gameObject.GetComponent<SpriteRenderer>().sprite = newSprite;
                ForwardMove();
                DiaginalMove();
                HorizontalMove();
                break;
            case ChessTypes.Knight:
                newSprite = pieceImages[2];
                gameObject.GetComponent<SpriteRenderer>().sprite = newSprite;
                Gizmos.DrawLine(transform.position, transform.position + new Vector3(0, 2, 0));
                Gizmos.DrawLine(transform.position + new Vector3(0, 2, 0), transform.position + new Vector3(1, 2, 0));
                Gizmos.DrawLine(transform.position + new Vector3(0, 2, 0), transform.position + new Vector3(-1, 2, 0));
                break;
        }
    }

    private void ForwardMove()
    {
        Gizmos.DrawLine(transform.position, transform.position + new Vector3(0,1,0));
    }
    private void HorizontalMove()
    {
        Gizmos.DrawLine(transform.position, transform.position + new Vector3(1, 0, 0));
        Gizmos.DrawLine(transform.position, transform.position + new Vector3(-1, 0, 0));
    }
    private void DiaginalMove()
    {
       
        Gizmos.DrawLine(transform.position, transform.position + new Vector3(1,1,0));
        Gizmos.DrawLine(transform.position, transform.position + new Vector3(-1, 1, 0));
    }
    private void ChangeIcon()
    {

    }
}
[CustomEditor(typeof(PotentialMoves))]
public class ExampleEditor : Editor
{
    // Custom in-scene UI for when ExampleScript
    // component is selected.
    public void OnSceneGUI()
    {
        var t = target as PotentialMoves;
        var tr = t.transform;
        var pos = tr.position;
        // display an orange disc where the object is
        var color = new Color(1, 0.8f, 0.4f, 1);
        Handles.color = color;
        Handles.DrawWireDisc(pos, tr.forward, 1.0f);
        // display object "value" in scene
        GUI.color = color;
        Handles.Label(pos, t.value.ToString("F1"));
    }
}
