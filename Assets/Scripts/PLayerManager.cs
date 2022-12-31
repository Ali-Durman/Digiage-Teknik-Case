using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using DG.Tweening;

public class PLayerManager : MonoBehaviour
{
    [SerializeField] private Transform _player;
    [SerializeField] private int _numberOfStickmans;
    [SerializeField] private TextMeshProUGUI _counterText;
    [SerializeField] private GameObject stickMan;
    //*****************************************************************

    [Range(0f,1f)] [SerializeField] private float distanceFactor, Radius;
    void Start()
    {
        _player = transform;
        _numberOfStickmans = transform.childCount - 1;
        _counterText.text = _numberOfStickmans.ToString();
    }

    void Update()
    {
        
    }

    private void FormatStickMan()
    {
        for (int i = 0; i < _player.childCount; i++)
        {
            var x = distanceFactor * Mathf.Sqrt(i) * Mathf.Cos(i * Radius);
            var z = distanceFactor * Mathf.Sqrt(i) * Mathf.Sin(i * Radius);

            var NewPos = new Vector3(x, y: 0.018f, z);
            _player.transform.GetChild(i).DOLocalMove(NewPos, duration: 1f).SetEase(Ease.OutBack);
        }
    }

    private void MakeStickMan(int number)
    {
        for (int i = 0; i < number; i++)
        {
            Instantiate(stickMan, transform.position, Quaternion.identity, transform);
        }

        _numberOfStickmans = transform.childCount - 1;
        _counterText.text = _numberOfStickmans.ToString();
        FormatStickMan();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Gate"))
        {
            other.transform.parent.GetChild(0).GetComponent<BoxCollider>().enabled = false; // Gate 1
            other.transform.parent.GetChild(1).GetComponent<BoxCollider>().enabled = false; // Gatr 2
            var GateManager = other.GetComponent<GateManager>();

            if (GateManager._multiply)
                MakeStickMan(_numberOfStickmans * GateManager._randomNumber);
            else
                MakeStickMan(_numberOfStickmans + GateManager._randomNumber);
        }
    }
}
