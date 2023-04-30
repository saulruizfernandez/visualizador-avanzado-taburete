// Autor: Saul Ruiz Fernandez
// Date: 30/04/2023

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class toggle_controlador : MonoBehaviour
{
    [SerializeField] Toggle respaldo_tog;
    [SerializeField] Toggle baseprin_tog;
    [SerializeField] Toggle basesec_tog;
    [SerializeField] Toggle tubo_tog;
    [SerializeField] Toggle pata1_tog;
    [SerializeField] Toggle pata2_tog;
    [SerializeField] Toggle soportepat_tog;

    [SerializeField] GameObject respaldo;
    [SerializeField] GameObject base_secundaria;
    [SerializeField] GameObject base_principal;
    [SerializeField] GameObject tubo_base;
    [SerializeField] GameObject pata1;
    [SerializeField] GameObject pata2;
    [SerializeField] GameObject soporte_patas;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void CuandoDropCambia()
    {
        if (!respaldo.activeSelf) respaldo_tog.isOn = false;
        else respaldo_tog.isOn = true;
        if (!base_principal.activeSelf) baseprin_tog.isOn = false;
        else baseprin_tog.isOn = true;
        if (!base_secundaria.activeSelf) basesec_tog.isOn = false;
        else basesec_tog.isOn = true;
        if (!tubo_base.activeSelf) tubo_tog.isOn = false;
        else tubo_tog.isOn = true;
        if (!pata1.activeSelf) pata1_tog.isOn = false;
        else pata1_tog.isOn = true;
        if (!pata2.activeSelf) pata2_tog.isOn = false;
        else pata2_tog.isOn = true;
        if (!soporte_patas.activeSelf) soportepat_tog.isOn = false;
        else soportepat_tog.isOn = true;
    }
}
