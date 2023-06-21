using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Botoes : MonoBehaviour
{
    //Chama no Onclick do botao de jogar e troca para scene do jogo
    public void TrocarCena(string alvo)
    {
       // cria um alvo em string para colocar o nome da scene que sera carregado
        SceneManager.LoadScene(alvo);

    }



    public void SairDjogo()
    {
        Application.Quit();
        Debug.Log(" funcionou");
    }



}
