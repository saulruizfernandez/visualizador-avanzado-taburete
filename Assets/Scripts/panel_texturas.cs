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

    [SerializeField] Toggle[] casillas;

    void Start()
    {
        rend_base_prin = base_principal.GetComponent<MeshRenderer>();
        rend_base_sec = base_secundaria.GetComponent<MeshRenderer>();
        rend_aro1 = aro1.GetComponent<MeshRenderer>();
        rend_aro2 = aro2.GetComponent<MeshRenderer>();
        rend_aro3 = aro3.GetComponent<MeshRenderer>();
        rend_tubo = tubo.GetComponent<MeshRenderer>();
        rend_pata1 = pata1.GetComponent<MeshRenderer>();
        rend_pata2 = pata2.GetComponent<MeshRenderer>();
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
        casillas[1].SetIsOnWithoutNotify(false);
        casillas[0].SetIsOnWithoutNotify(true);
    }

    public void Selectmadera2()
    {
        rend_base_prin.material = madera2;
        rend_base_sec.material = madera2;
        casillas[0].SetIsOnWithoutNotify(false);
        casillas[1].SetIsOnWithoutNotify(true);
    }

    public void Selectmetal1()
    {
        rend_tubo.material = metal1;
        rend_pata1.material = metal1;
        rend_pata2.material = metal1;
        rend_soporte_pat.material = metal1;
        rend_pasador.material = metal1;
        rend_respaldo.material = metal1;
        // casillas[2].isOn = true;
        //casillas[3].isOn = false;
    }

    public void Selectmetal2()
    {
        rend_tubo.material = metal2;
        rend_pata1.material = metal2;
        rend_pata2.material = metal2;
        rend_soporte_pat.material = metal2;
        rend_pasador.material = metal2;
        rend_respaldo.material = metal2;
        //casillas[3].isOn = true;
        //casillas[2].isOn = false;
    }

    public void Selectazul()
    {
        rend_aro1.material = azul;
        rend_aro2.material = azul;
        rend_aro3.material = azul;
        //casillas[3].isOn = false;
    }

    public void Selectmarron()
    {
        rend_aro1.material = marron;
        rend_aro2.material = marron;
        rend_aro3.material = marron;
        //casillas[3].isOn = true;
        //casillas[2].isOn = false;
    }
}
