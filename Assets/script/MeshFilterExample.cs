using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshFilterExample : MonoBehaviour
{
    public MeshFilter myMeshFilter;
    public Mesh mesh;
    void Start()
    {
        Invoke("changeMesh", 1f);
        // change the mesh of themeshfilter to display
    }

    void changeMesh()
    {
        myMeshFilter.mesh = mesh;
    }
}
