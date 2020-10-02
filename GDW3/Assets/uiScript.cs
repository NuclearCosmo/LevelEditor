﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uiScript : MonoBehaviour
{
    private int down = 0;
    public GameObject objectToSpawnPrefab;
    public Transform pointPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Input.mousePosition;
        if (Input.GetKey(KeyCode.Mouse0) && down == 0)
        {
            down = 1;
            if (transform.position.x - 50 <= mousePos.x && transform.position.x + 50 >= mousePos.x && transform.position.y - 50 <= mousePos.y && transform.position.y + 50 >= mousePos.y)
            {
                GameObject objects = Instantiate(objectToSpawnPrefab) as GameObject;
                objects.transform.position = pointPos.transform.position;
            }
        }
        else if (Input.GetKey(KeyCode.Mouse1) && down == 1)
        {
            ;
        }
        else
        {
            down = 0;
        }
    }
}