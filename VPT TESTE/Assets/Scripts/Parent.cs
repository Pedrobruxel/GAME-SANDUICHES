using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Parent : MonoBehaviour
{
    // código que para setar o parent dos sanduiches dentro da cena 
    public Transform parent;
      
    // função de start para mover o sanduiche para sua hierarquia apos o update 
    void Start()
    {
        SetParent();          
                       
    }
    // função para selecionar o pai 
    public void SetParent()
    {
        transform.SetParent(parent);
    }
}

