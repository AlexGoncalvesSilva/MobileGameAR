using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerMenu : MonoBehaviour
{

    public GameObject aboutPanel;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void openAboutPanel()
    {
        aboutPanel.SetActive(true);
    }

    public void closeAboutPanel()
    {
        aboutPanel.SetActive(false);
    }
}
