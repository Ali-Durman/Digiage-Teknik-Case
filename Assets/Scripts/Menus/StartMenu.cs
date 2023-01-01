using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMenu : MonoBehaviour
{
    bool buttonPressed = true;
    float timer  = 0;
    float duration = 1f;

    public GameObject Canvas;
    public GameObject Cube;
    
    [SerializeField] Material[] mats;

    public void ColorB()
    {
        if (buttonPressed == false)
            {
                int random = Random.Range(0, 10);
                Cube.GetComponent<MeshRenderer> ().material = mats[random];
                buttonPressed = true;
            }
        else
        {Debug.Log("Cooldown");}
    }
    public void StartB()
    {
        Canvas.SetActive(false);
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(buttonPressed)
        {
            timer+=Time.deltaTime;
            if(timer>=duration)
            {
                timer = 0;
                buttonPressed = false;
            }
        }
    }
}
