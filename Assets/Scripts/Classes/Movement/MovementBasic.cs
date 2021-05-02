using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementBasic : MonoBehaviour,IMovement
{
    List<Vector3> Points=new List<Vector3>();
    float Speed;
    void Start()
    {
        
    }

    void Update()
    {
        if(Points.Count>0)
        {
            transform.position = Points[0];
            Points.RemoveAt(0);
        }
    }

    public void Move(List<Vector3> points, float speed)
    {
        Points = points;
        Speed = speed;
    }
}
