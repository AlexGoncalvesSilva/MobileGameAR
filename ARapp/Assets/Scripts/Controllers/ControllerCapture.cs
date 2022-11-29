using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerCapture : MonoBehaviour
{

    public static ControllerCapture instance;

    public GameObject[] Animals;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;

        witchAnimal();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void witchAnimal()
    {
        for (int i = 0; i <= 19; i++)
        {
            if(i == Sorteador.instance.numSorteado)
            {
                Animals[i].SetActive(true);
            }
            else
            {
                Animals[i].SetActive(false);
            }

        }
    }
}
