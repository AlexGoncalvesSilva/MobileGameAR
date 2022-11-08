using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalRegister : MonoBehaviour
{
    public static AnimalRegister instance;

    public bool catalogou = false;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    { 

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void clickCameraButton()
    {
        catalogou = true;
    }
}
