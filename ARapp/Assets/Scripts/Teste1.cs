using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teste1 : MonoBehaviour
{


    public GameObject galinhaBranca;
    public GameObject galinhaMarrom;

    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    IEnumerator rotinaTarget()
    {
        yield return new WaitForSeconds(1f);
        galinhaBranca.SetActive(false);
        galinhaMarrom.SetActive(true);
    }

    public void onTarget()
    {
        StartCoroutine("rotinaTarget");
    }

    public void lostTarget()
    {
        galinhaMarrom.SetActive(false);
        galinhaBranca.SetActive(true);
    }
}
