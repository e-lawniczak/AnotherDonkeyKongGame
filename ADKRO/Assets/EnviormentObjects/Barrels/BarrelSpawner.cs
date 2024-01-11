using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject barrel;
    [SerializeField]
    private float spawnTimer = 2f;
    private float _timer = 0f;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
    }

    // Update is called once per frame
    void Update()
    {
        _timer += Time.deltaTime;
        if(_timer >= spawnTimer)
        {
            Object.Instantiate(barrel);
            _timer = 0f;
        }
    }
}
