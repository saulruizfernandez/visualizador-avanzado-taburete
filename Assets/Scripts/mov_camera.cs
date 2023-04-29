// Autor: Saúl Ruiz Fernández
// Fecha: 29/04/2023
// Comentarios: programa para la navegación de la cámara, incluye zoom y rotación alrededor del taburete

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mov_camera : MonoBehaviour
{
    private Camera main_camera;
    [SerializeField] Transform silla;
    private float zoom_speed = 20.0f;
    private float rotation_speed = 5.0f;
    private float min_zoom_dist = 2.0f;
    private float max_zoom_dist = 60.0f; // Se bloquea el zoom-out en la posición incial

    // Variables para almacenar la posición y rotación inicial de la cámara
    Quaternion angulos_inciales;
    Vector3 posicion_incial;

    void Start()
    {
        main_camera = Camera.main;
        angulos_inciales = this.transform.rotation;
        posicion_incial = this.transform.position;
    }

    void Update()
    {
        // Rotación de la camára
        if (Input.GetMouseButton(0)) {
            main_camera.transform.RotateAround(silla.transform.position,
                                               main_camera.transform.up,
                                               Input.GetAxis("Mouse X") * rotation_speed);
            main_camera.transform.RotateAround(silla.transform.position,
                                               main_camera.transform.right,
                                               -Input.GetAxis("Mouse Y") * rotation_speed);
        }
        // Zoom de la cámara en un rango limitado
        main_camera.fieldOfView -= Input.GetAxis("Mouse ScrollWheel") * zoom_speed;
        if (main_camera.fieldOfView < min_zoom_dist){
            main_camera.fieldOfView = min_zoom_dist;
        }
        if (main_camera.fieldOfView > max_zoom_dist){
            main_camera.fieldOfView = max_zoom_dist;
        }
        // Centramos la visión de la cámara en el foco del taburete
        main_camera.transform.LookAt(silla.position);
        // Si se presiona 'r' se resetea la posición
        if (Input.GetKey(KeyCode.R)) {
            Reset();
        }
    }

    // Resetear la posición de la cámara si el botón de RESET está presionado
    public void Reset() {
        this.transform.rotation = angulos_inciales;
        this.transform.position = posicion_incial;
        main_camera.fieldOfView = 60;
    }
}
