using UnityEngine;

public class Desafio5 : MonoBehaviour
{

    public string jogador_1;
    public string jogador_2;

    public bool mao_jogador1_eh_par;
    public bool mao_jogador1_eh_impar;

    public bool mao_jogador2_eh_par;
    public bool mao_jogador2_eh_impar;

    public bool jogador1_selecionou_par;
    public bool jogador1_selecionou_impar;

    public bool jogador2_selecionou_par;
    public bool jogador2_selecionou_impar;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (mao_jogador1_eh_par && jogador1_selecionou_par && mao_jogador2_eh_impar && jogador2_selecionou_impar)
        {

            Debug.Log(jogador_2 + " vence a partida com ímpar!");
            
        }

        if (mao_jogador1_eh_impar && jogador1_selecionou_impar && mao_jogador2_eh_par && jogador2_selecionou_par)
        {

            Debug.Log(jogador_1 + " vence a partida com ímpar!");
           
        }

        if (mao_jogador1_eh_impar && jogador1_selecionou_impar && mao_jogador2_eh_impar && jogador2_selecionou_par)
        {

            Debug.Log(jogador_2 + " vence a partida com par!");
           
        }

        if (mao_jogador1_eh_par && jogador1_selecionou_impar && mao_jogador2_eh_par && jogador2_selecionou_par)
        {

            Debug.Log(jogador_1 + " vence a partida com par!");
            
        }

        if(mao_jogador1_eh_impar && jogador1_selecionou_impar && mao_jogador2_eh_par && jogador2_selecionou_impar)
        {

            Debug.Log(jogador_1 + " vence a partida com par!");
          
        }

        if (mao_jogador1_eh_par && jogador1_selecionou_par && mao_jogador2_eh_par && jogador2_selecionou_impar)
        {

            Debug.Log(jogador_2 + " vence a partida com par!");
            
        }

        if (mao_jogador1_eh_par && jogador1_selecionou_impar && mao_jogador2_eh_impar && jogador2_selecionou_par)
        {

            Debug.Log(jogador_1 + " vence a partida com impar!");
            
        }

        if (mao_jogador1_eh_impar && jogador1_selecionou_par && mao_jogador2_eh_impar && jogador2_selecionou_impar)
        {

            Debug.Log(jogador_1 + " vence a partida com par!");
           
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}