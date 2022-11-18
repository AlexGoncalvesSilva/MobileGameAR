using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButtons : MonoBehaviour
{

    public GameObject menuPanel;
    public GameObject exitPanel;
    public GameObject configPanel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void menuButton()
    {
        menuPanel.SetActive(true);
    }

    public void configButton()
    {
        configPanel.SetActive(true);
    }

    public void exitButton()
    {
        exitPanel.SetActive(true);
    }

    public void confirmExit()
    {
        Application.Quit();
    }

    public void closePanel()
    {
        exitPanel.SetActive(false);
        configPanel.SetActive(false);
        menuPanel.SetActive(false);
    }
}
