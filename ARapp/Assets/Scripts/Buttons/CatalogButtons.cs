using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatalogButtons : MonoBehaviour
{

    public GameObject CaatingaPanel;
    public GameObject CerradoPanel;
    public GameObject MataAtlanticaPanel;
    public GameObject AmazoniaPanel;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonCaatinga()
    {
        CaatingaPanel.SetActive(true);
        CerradoPanel.SetActive(false);
        MataAtlanticaPanel.SetActive(false);
        AmazoniaPanel.SetActive(false);
    }
    public void ButtonCerrado()
    {
        CaatingaPanel.SetActive(false);
        CerradoPanel.SetActive(true);
        MataAtlanticaPanel.SetActive(false);
        AmazoniaPanel.SetActive(false);
    }
    public void ButtonMataAltantica()
    {
        CaatingaPanel.SetActive(false);
        CerradoPanel.SetActive(false);
        MataAtlanticaPanel.SetActive(true);
        AmazoniaPanel.SetActive(false);
    }
    public void ButtonAmazonia()
    {
        CaatingaPanel.SetActive(false);
        CerradoPanel.SetActive(false);
        MataAtlanticaPanel.SetActive(false);
        AmazoniaPanel.SetActive(true);
    }

}
