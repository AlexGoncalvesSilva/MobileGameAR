using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sorteador : MonoBehaviour
{
  
    public int numSorteado;

    public static Sorteador instance;

    private void Awake()
    {
        instance = this;
        numSorteado = Random.Range(0, 20);
        Debug.Log("Sorteado o número: " + numSorteado);
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
