using System.Collections.Generic;
using UnityEngine;

public abstract class Node : MonoBehaviour
{

    public Transform cameraPosition;
    public List<Node> adjacentNodes;

    [HideInInspector]
    public Collider col;

    void Start()
    {
        adjacentNodes = new List<Node>();
        col = GetComponent<Collider>();
    }
}
