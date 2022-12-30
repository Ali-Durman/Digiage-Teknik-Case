using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float _playerSpeed;
    public bool isMoving;
    public static PlayerMove Instance;
    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    private void Update()
    {
        if (!isMoving) return;
        transform.Translate(Vector3.forward * _playerSpeed * Time.deltaTime);
    }

}
