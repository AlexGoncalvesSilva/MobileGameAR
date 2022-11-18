using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conquistas : MonoBehaviour
{

    public GameObject imageCheck;

    // Start is called before the first frame update
    void Start()
    {
        if (AnimalRegister.instance.catalogou == true)
        {
            imageCheck.SetActive(true);
        }
        else
        {
            imageCheck.SetActive(false);
        }
            
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
