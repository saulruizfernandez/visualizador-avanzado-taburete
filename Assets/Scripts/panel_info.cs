// Autor: Saúl Ruiz Fernández
// Date: 29/04/2023
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class panel_info : MonoBehaviour
{
    public GameObject panel;
    public bool pulsadoI = false;
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKey(KeyCode.I)) {
            if (pulsadoI == true) {
                panel.SetActive(true);
                pulsadoI = false;
            }
         }
    }

    public void PulsaI()
    {
        pulsadoI = true;
        panel.SetActive(false);
    }
}
