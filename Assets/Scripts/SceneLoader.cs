using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] private PLayerManager playermanager;
    [SerializeField] private GameObject _loseCanvas;
    [SerializeField] private GameObject _winCanvas;

    public void LoadScene()
    {
        SceneManager.LoadScene("Level1");
        
    }

    private void Start()
    {
        playermanager = GetComponent<PLayerManager>();
        
        _winCanvas.SetActive(false);
        _loseCanvas.SetActive(false);
    }

    private void Update()
    {
        if (playermanager._numberOfStickmans == 0 )
        {
            _loseCanvas.SetActive(true);
        }
    }

}
