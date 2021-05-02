using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMovement 
{
    public void Move(List<Vector3> points,float speed);
}
