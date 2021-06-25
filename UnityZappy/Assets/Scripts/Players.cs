using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Players : MonoBehaviour
{
    public float zp;
    public float xp;
    public Transform player;
    private Vector3 pos;

    void Awake() 
    {
        transform.Rotate(0.0f, Random.Range(0.0f, 360.0f), 0.0f);
        transform.position = new Vector3(Random.Range(-(xp), xp), 0.0f, Random.Range(-(zp), zp));
    }
}
