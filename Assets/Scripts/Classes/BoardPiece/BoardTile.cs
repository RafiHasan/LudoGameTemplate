using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardTile : MonoBehaviour
{
    public BoardTileData boardtiledata;
    void Start()
    {
        Instantiate(boardtiledata.Body, transform);
    }

    void Update()
    {
        
    }
}
