using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Parent : MonoBehaviour
{
    // c�digo que para setar o parent dos sanduiches dentro da cena 
    public Transform parent;
      
    // fun��o de start para mover o sanduiche para sua hierarquia apos o update 
    void Start()
    {
        SetParent();          
                       
    }
    // fun��o para selecionar o pai 
    public void SetParent()
    {
        transform.SetParent(parent);
    }
}

