using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Island : MonoBehaviour
{

    public GameObject animal;

    // Start is called before the first frame update
    void Start()
    {
        if (AnimalRegister.instance.catalogou == true)
        {
            animal.SetActive(true);
            Debug.Log("Catalogou");
        }
        if (AnimalRegister.instance.catalogou == false)
        {
            animal.SetActive(false);
            Debug.Log("Nada catalogado");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
