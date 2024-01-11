using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Barrel : MonoBehaviour
{
    private UnityEngine.Camera _camera;
    private bool _enabled = false;
    void Start()
    {
        _camera = UnityEngine.Camera.main;

    }

    void Update()
    {
        if (_enabled)
            Debug.Log("enabled");
    }
    void OnBecameVisible()
    {
        _enabled = true;
    }
    void deleteThis()
    {
        Debug.Log("I'm out");
        Console.Write(this);
        Destroy(this);
    }
}
