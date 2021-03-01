using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public enum Direction
    {
        NORTH,
        SOUTH,
        EAST,
        WEST,
    };

    public Direction cardinalDirection;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 cameraDirection = Camera.main.transform.forward;
        if (Vector3.Dot(cameraDirection, Vector3.forward) == 1) cardinalDirection = Direction.NORTH;
        else if (Vector3.Dot(cameraDirection, Vector3.forward) == 0) cardinalDirection = Direction.SOUTH;
        else if (Vector3.Dot(cameraDirection, Vector3.right) == 1) cardinalDirection = Direction.EAST;
        else cardinalDirection = Direction.WEST;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Camera.main.transform.eulerAngles);
    }
}
