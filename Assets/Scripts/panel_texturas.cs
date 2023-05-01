// Autor: Saul Ruiz Fernandez
// Date: 1/05/2023

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class panel_texturas : MonoBehaviour
{
    [SerializeField] GameObject base_principal;
    [SerializeField] GameObject aro1;
    [SerializeField] GameObject aro2;
    [SerializeField] GameObject aro3;
    [SerializeField] GameObject base_secundaria;
    [SerializeField] GameObject tubo;
    [SerializeField] GameObject pata1;
    [SerializeField] GameObject pata2;
    [SerializeField] GameObject soporte_pat;
    [SerializeField] GameObject pasador;
    [SerializeField] GameObject respaldo;

    MeshRenderer rend_base_prin;
    MeshRenderer rend_aro1;
    MeshRenderer rend_aro2;
    MeshRenderer rend_aro3;
    MeshRenderer rend_base_sec;
    MeshRenderer rend_tubo;
    MeshRenderer rend_pata1;
    MeshRenderer rend_pata2;
    MeshRenderer rend_soporte_pat;
    MeshRenderer rend_pasador;
    MeshRenderer rend_respaldo;

    [SerializeField] Material madera1;
    [SerializeField] Material madera2;

    [SerializeField] Material metal1;
    [SerializeField] Material metal2;

    [SerializeField] Material azul;
    [SerializeField] Material marron;

    [SerializeField] Toogle[] casillas;

    void Start()
    {
        rend_base_prin = base_principal.GetComponent<MeshRenderer>();
        rend_aro1 = aro1.GetComponent<MeshRenderer>();
        rend_aro2 = aro2.GetComponent<MeshRenderer>();
        rend_aro3 = aro3.GetComponent<MeshRenderer>();
        rend_tubo = tubo.GetComponent<MeshRenderer>();
        rend_pata1 = pata1.GetComponent<MeshRenderer>();
        rend_aro1 = pata2.GetComponent<MeshRenderer>();
        rend_soporte_pat = soporte_pat.GetComponent<MeshRenderer>();
        rend_pasador = pasador.GetComponent<MeshRenderer>();
        rend_respaldo = respaldo.GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Selectmadera1()
    {
        rend_base_prin.material = madera1;
        rend_base_sec.material = madera1;
        casillas[0].isOn = true;
        casillas[1].isOn = false;
    }

    public void Selectmadera2()
    {
        rend_base_prin.material = madera2;
        rend_base_sec.material = madera2;
    }

    public void Selectmetal1()
    {
        rend_base_prin.material = metal1;
        rend_aro1.material = metal1;
        rend_aro2.material = metal1;
        rend_aro3.material = metal1;
        rend_base_sec.material = metal1;
    }

    public void Selectmetal2()
    {
        rend_base_prin.material = metal2;
        rend_aro1.material = metal2;
        rend_aro2.material = metal2;
        rend_aro3.material = metal2;
        rend_base_sec.material = metal2;
    }
}
