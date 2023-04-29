using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class reset_button : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] Sprite boton_sin_pulsar;
    [SerializeField] Sprite boton_pulsado;
    Button btn;

    void Start()
    {
        btn = this.GetComponent<Button>();
        btn.image.sprite = boton_sin_pulsar;
    }

    void Update()
    {

    }

    public void OnPointerDown(PointerEventData eventData) 
    {
        btn.image.sprite = boton_pulsado;
    }

    public void OnPointerUp(PointerEventData eventData) 
    {
        btn.image.sprite = boton_sin_pulsar;
    }  
}
