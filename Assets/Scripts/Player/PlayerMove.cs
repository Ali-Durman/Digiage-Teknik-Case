using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float _playerSpeed;
    public bool isMoving;
    [SerializeField] private Animator anim;
    public static PlayerMove Instance;
    private void Awake()
    {
        anim = GetComponent<Animator>();

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
        anim.SetTrigger("run");
        transform.Translate(Vector3.forward * _playerSpeed * Time.deltaTime);
    }

}
