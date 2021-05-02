using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pawn : MonoBehaviour
{
    public PawnData pawndata;
    public BoardData boardData;
    IMovement movement;
    void Start()
    {
        Instantiate(pawndata.Body,transform);
    }

    void Update()
    {
        movement.Move(new List<Vector3>(),pawndata.Speed);
    }
}
