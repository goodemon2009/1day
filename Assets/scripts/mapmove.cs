using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mapmove : MonoBehaviour
{
    public float MapSpeed = 5f;

    private Transform tr;

    void Start()
    {
        tr = GetComponent<Transform>();
    }

    void Update()
    {
        tr.Translate(Vector2.left * MapSpeed * Time.deltaTime);
    }
}
