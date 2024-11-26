using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{
    [SerializeField] bool IsPlaceable;
    private void OnMouseDown()
    {
        if (IsPlaceable)
        {
            //Debug.Log("hello");
        }
    }
}
