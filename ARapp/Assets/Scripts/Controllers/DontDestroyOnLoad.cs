using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyOnLoad : MonoBehaviour
{

    [HideInInspector] public string objectID;

    private void Awake()
    {
        objectID = name + transform.position.ToString();
    }

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < Object.FindObjectsOfType<DontDestroyOnLoad>().Length ; i++ )
        {
            if (Object.FindObjectsOfType<DontDestroyOnLoad>()[i] != this)
            {
                if(Object.FindObjectsOfType<DontDestroyOnLoad>()[i].objectID == objectID)
                {
                    Destroy(gameObject);
                }

            }

        }

        DontDestroyOnLoad(gameObject);
    }

}
