// Autor: Saúl Ruiz Fernández
// Date: 29/04/2023
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class panel_info : MonoBehaviour
{
    [SerializeField] GameObject panel;
    Animator animator;
    void Start()
    {
        animator = panel.GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.I)) {
            animator.ResetTrigger("abr-cierra");
            animator.SetTrigger("cierra-abr");
        }
    }
}
