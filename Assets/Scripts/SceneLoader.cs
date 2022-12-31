using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] private GameObject _loseCanvas;
    [SerializeField] private GameObject _winCanvas;
    public void LoadScene()
    {
        SceneManager.LoadScene("Level1");
        
    }

    private void Start()
    {
        _winCanvas.SetActive(false);
        _loseCanvas.SetActive(false);
    }



}
