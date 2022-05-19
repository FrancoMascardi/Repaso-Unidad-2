using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActivateDesactivar : MonoBehaviour
{
    public GameObject InputField;
    public bool wasPressed;
    void Start()
    {
        //wasPressed = false;
    }
    public void ActivateAndDeactivate()
    {
        //if (!wasPressed)
        //{
        //    InputField.SetActive(false);
        //    wasPressed = true;
        //}
        //else
        //{
        //    InputField.SetActive(true);
        //    wasPressed = false;
        //}


        //if (InputField.activeInHierarchy)
        //{
        //    InputField.SetActive(false);
        //}
        //else
        //{
        //    InputField.SetActive(true);
        //}


        InputField.SetActive(!InputField.activeInHierarchy);
        //si es verdadero, el ! me lo devuelve como falso y si esta en falso me lo devuelve en verdadero

    }
}
