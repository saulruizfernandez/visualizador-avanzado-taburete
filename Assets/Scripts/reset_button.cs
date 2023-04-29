using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class reset_button : MonoBehaviour
{
    [SerializeField] Sprite boton_sin_pulsar;
    [SerializeField] Sprite boton_pulsado;
    Image imagen;

    void Start()
    {
        imagen = this.GetComponent<Image>();
        imagen.sprite = boton_sin_pulsar;   
    }

    void Update()
    {

    }

    void ChangeSprite()
    {
        imagen.sprite = boton_pulsado;
    }
    void ResetSprite()
    {
        imagen.sprite = boton_sin_pulsar;
    }
}
