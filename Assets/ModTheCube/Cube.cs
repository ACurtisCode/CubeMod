﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    
    void Start()
    {
        transform.position = new Vector3(-3, 0, 2);
        transform.localScale = Vector3.one * 1.3f;
        
        Material material = Renderer.material;
        
        material.color = new Color(25.0f, 25.0f, 25.0f, 0.4f);
    }
    
    void Update()
    {
        transform.Rotate(45.0f * Time.deltaTime, 0.0f, 0.0f);
    }
}
