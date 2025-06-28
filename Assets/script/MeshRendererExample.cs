using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshRendererExample : MonoBehaviour
{
    public MeshRenderer myMeshRenderer;
    void Start()
    {
        myMeshRenderer.material.color = Color.yellow;
    }
}
