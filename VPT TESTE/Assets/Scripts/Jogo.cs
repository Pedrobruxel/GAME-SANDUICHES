using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.ParticleSystem;

public class Jogo : MonoBehaviour
{
   // txt para a o display de escrita do tempo
    public Text displayTempo;
   // txt para contagem do tempo
    public Text tempo_txt;
    // txt para anunciar fim do jogo
    public Text semTempo;
   // float para armazenar as inforamçoes do tempo
    public float tempo = 120;
    // transform para definir a posição do sanduiche
    public Transform position;
    // lista dos sanduiches
    public GameObject[] sanduiche;
    


    public void Start()
    {

        InstanciarSanduiche();

    }


    // função update para realizar a contagem do tempo 
    public void Update()
    {



        // if para 
        if (tempo > 1)
        {


            Time.timeScale = 1;
            tempo -= Time.deltaTime;
            displayTempo.text = tempo.ToString("F0");



        }
        else
        {
            displayTempo.text = "Acabou o seu tempo ";
            tempo_txt.text = "";
            displayTempo.enabled = false;
            
            semTempo.text = " FIM DO JOGO SEU TEMPO ACABOU";
            



        }

    }
    // função instantiante para instanciar um sanduiche aleatorio entre os 5 na cena na posição definida no transform.
    public void InstanciarSanduiche()
    {
        // 
        int n = Random.Range(0, sanduiche.Length);
        Instantiate(sanduiche[n], position.position,transform.rotation);
        

    }




}




