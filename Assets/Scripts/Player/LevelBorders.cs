using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBorders : MonoBehaviour
{
    [SerializeField] private float minX;
    [SerializeField] private float maxX;
    void Update()
    {
        float xPos = Mathf.Clamp(transform.position.x, minX, maxX);
        transform.position = new Vector3(xPos, transform.position.y, transform.position.z);
    }
}
