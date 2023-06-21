using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Montagem : MonoBehaviour
{
    public int pontos;
    public Text pontuacao;
    // botoes dos ingredientes
    public Button alface;
    public Button cebola;
    public Button picles;
    public Button tomate;
    public Button ovo;
    public Button queijo;
    public Button presunto;
    public Button hamburguer;
    public Button pao_hamburger;
    public Button pao_sanduiche;

    public Jogo sand;





    public void SelecionarIngred()
    {
        if (sand.sanduiche[1] == alface == picles == tomate)
        {
            pontos += 5;
            pontuacao.text = "sua pontuação é de " + pontos;

        }

      






        /*
        public void sanduiche1()
        {
            if (sand.sanduiche[1])
                alface.onClick.AddListener(SelecionarIngred);
            picles.onClick.AddListener(SelecionarIngred);
            tomate.onClick.AddListener(SelecionarIngred);
            presunto.onClick.AddListener(SelecionarIngred);
            queijo.onClick.AddListener(SelecionarIngred);
            ovo.onClick.AddListener(SelecionarIngred);


        }
        */





    }
}




