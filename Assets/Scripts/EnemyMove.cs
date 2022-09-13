using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemyMove : MonoBehaviour
{
    [SerializeField]private float Speed;

    void Start()
    {
        
    }


    void Update()
    {

        transform.position -= transform.up * Speed * Time.deltaTime;

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        transform.Rotate(transform.position.x, 0, transform.position.z);
    }
}
