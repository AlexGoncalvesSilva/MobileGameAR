using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Island : MonoBehaviour
{

    public GameObject animal;
    public GameObject cubo;

    // Start is called before the first frame update
    void Start()
    {
  
    }

    // Update is called once per frame
    void Update()
    {
        animalSpawn();
    }

    void animalSpawn()
    {
        if (AnimalRegister.instance.catalogou == true)
        {
            cubo.SetActive(false);
            animal.SetActive(true);
            Debug.Log("Catalogou");
        }
        if (AnimalRegister.instance.catalogou == false)
        {
            cubo.SetActive(true);
            animal.SetActive(false);
            Debug.Log("Nada catalogado");
        }
    }
}
