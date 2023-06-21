using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sanduiches : MonoBehaviour
{
    // acesso ao script Cardapio
    public Cardapio ingredientes;
    public GameObject[] sanduiches;

  // criação de text para aparecer o nome e os ingredientes do sanduiche.
    public Text nomeSand;
    public Text ingrediente1;
    public Text ingrediente2;
    public Text ingrediente3;
    public Text ingrediente4;
    public Text ingrediente5;
    public Text ingrediente6;

    // variavel para imagem do sanduiche
    public Image sanduiche;
    

    // função que ira printar no inicio os nomes e ingredientes do sanduiche na cena .
    void Start()
    {
        nomeSand.text = ingredientes.nomeSand;
        ingrediente1.text = ingredientes.ingrediente1;
        ingrediente2.text = ingredientes.ingrediente2;
        ingrediente3.text = ingredientes.ingrediente3;
        ingrediente4.text = ingredientes.ingrediente4;
        ingrediente5.text = ingredientes.ingrediente5;
    }

    






}
