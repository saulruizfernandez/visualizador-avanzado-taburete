// Autor: Saúl Ruiz Fernández
// Date: 29/04/2023

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class panel_mod : MonoBehaviour
{
    [SerializeField] GameObject respaldo;
    [SerializeField] GameObject base_secundaria;
    [SerializeField] GameObject base_principal;
    [SerializeField] GameObject aro1;
    [SerializeField] GameObject aro2;
    [SerializeField] GameObject aro3;
    [SerializeField] GameObject tubo_base;
    [SerializeField] GameObject pata1;
    [SerializeField] GameObject pasador;
    [SerializeField] GameObject pata2;
    [SerializeField] GameObject soporte_patas;

    [SerializeField] Dropdown desplegable;

    void Start()
    {
        
    }


    void Update()
    {

    }

    public void CambioDrop()
    {
        switch (desplegable.value) {
            case 0:
                respaldo.SetActive(true);
                base_secundaria.SetActive(true);
                base_principal.SetActive(true);
                tubo_base.SetActive(true);
                pata1.SetActive(true);
                pata2.SetActive(true);
                soporte_patas.SetActive(true);
                aro1.SetActive(true);
                aro2.SetActive(true);
                aro3.SetActive(true);
                pasador.SetActive(true);
                break;
            case 1:
                respaldo.SetActive(false);
                base_secundaria.SetActive(false);
                base_principal.SetActive(true);
                tubo_base.SetActive(false);
                pata1.SetActive(false);
                pata2.SetActive(false);
                soporte_patas.SetActive(false);
                aro1.SetActive(true);
                aro2.SetActive(true);
                aro3.SetActive(true);
                pasador.SetActive(false);
                break;
            case 2:
                respaldo.SetActive(false);
                base_secundaria.SetActive(true);
                base_principal.SetActive(false);
                tubo_base.SetActive(false);
                pata1.SetActive(false);
                pata2.SetActive(false);
                soporte_patas.SetActive(false);
                aro1.SetActive(false);
                aro2.SetActive(false);
                aro3.SetActive(false);
                pasador.SetActive(false);
                break;
            case 3:
                respaldo.SetActive(false);
                base_secundaria.SetActive(false);
                base_principal.SetActive(false);
                tubo_base.SetActive(true);
                pata1.SetActive(false);
                pata2.SetActive(false);
                soporte_patas.SetActive(false);
                aro1.SetActive(false);
                aro2.SetActive(false);
                aro3.SetActive(false);
                pasador.SetActive(false);
                break;
            case 4:
                respaldo.SetActive(false);
                base_secundaria.SetActive(false);
                base_principal.SetActive(false);
                tubo_base.SetActive(false);
                pata1.SetActive(true);
                pata2.SetActive(false);
                soporte_patas.SetActive(false);
                aro1.SetActive(false);
                aro2.SetActive(false);
                aro3.SetActive(false);
                pasador.SetActive(true);
                break;
            case 5:
                respaldo.SetActive(false);
                base_secundaria.SetActive(false);
                base_principal.SetActive(false);
                tubo_base.SetActive(false);
                pata1.SetActive(false);
                pata2.SetActive(true);
                soporte_patas.SetActive(false);
                aro1.SetActive(false);
                aro2.SetActive(false);
                aro3.SetActive(false);
                pasador.SetActive(false);
                break;
            case 6:
                respaldo.SetActive(false);
                base_secundaria.SetActive(false);
                base_principal.SetActive(false);
                tubo_base.SetActive(false);
                pata1.SetActive(false);
                pata2.SetActive(false);
                soporte_patas.SetActive(true);
                aro1.SetActive(false);
                aro2.SetActive(false);
                aro3.SetActive(false);
                pasador.SetActive(false);
                break;
        }
    }
}
