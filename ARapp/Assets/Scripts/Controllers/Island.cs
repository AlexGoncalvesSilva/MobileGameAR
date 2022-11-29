using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Island : MonoBehaviour
{

    public GameObject Animal;   

    // Start is called before the first frame update
    void Start()
    {
        animalSpawn();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void animalSpawn()
    {
        if (AnimalRegister.instance.catalogou == true)
        {
            Animal.SetActive(true);
            Debug.Log("Catalogou");
        }
        if (AnimalRegister.instance.catalogou == false)
        {
            Animal.SetActive(false);
            Debug.Log("Nada catalogado");
        }
    }
}
