using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] private GameObject _loseCanvas;
    public void LoadScene()
    {
        SceneManager.LoadScene("Level1");
        
    }

    private void Start()
    {
        _loseCanvas.SetActive(false);
    }



}
