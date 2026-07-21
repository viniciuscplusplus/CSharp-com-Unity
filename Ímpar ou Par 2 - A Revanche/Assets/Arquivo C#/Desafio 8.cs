using UnityEngine;
using UnityEngine.UI;


public class Desafio8 : MonoBehaviour
{
   
    public InputField jogador_1_nome;
    public InputField escolha_jogador_1;
    public InputField escolha_mao_Jogador_1;
    public Text texto_vencedor;


    public Text campo_escolha_jogador2;
    public Text campo_mao_jogador2;

     public void botão()
    {
        
    if (escolha_jogador_1.text == "ímpar")
        {
            campo_escolha_jogador2.text = "par";
            Debug.Log("entrou no if impar " + campo_escolha_jogador2);

            int numero_aleatorio = Random.Range(0 , 2);

             if(numero_aleatorio == 0)
            {
                campo_mao_jogador2.text = "par";
            }

            else
            {
                campo_mao_jogador2.text = "ímpar";
            }


            if(escolha_mao_Jogador_1.text == "par" && campo_mao_jogador2.text == "ímpar")
               {
               texto_vencedor.text="O jogador " + jogador_1_nome.text + "venceu"; // tá certo
               }

            else if (escolha_mao_Jogador_1.text == "ímpar" && campo_mao_jogador2.text == "par")
              {
            texto_vencedor.text="O jogador " + jogador_1_nome.text + "venceu"; // tá certo
              }  

            else if (escolha_mao_Jogador_1.text == "ímpar" && campo_mao_jogador2.text == "ímpar")
              {
                texto_vencedor.text="A máquina venceu"; // tá certo
              }  

            else 
              {
                texto_vencedor.text="A máquina ganhou"; // tá certo
              }   
            
        }

    if (escolha_jogador_1.text == "par")
        {
            campo_escolha_jogador2.text = "ímpar";
            Debug.Log("entrou no if par " + campo_escolha_jogador2);
            int numero_aleatorio = Random.Range(0 , 2);

             if(numero_aleatorio == 0)
            {
                campo_mao_jogador2.text = "par";
            }

            else
            {
                campo_mao_jogador2.text = "ímpar";
            }

             if(escolha_mao_Jogador_1.text == "par" && campo_mao_jogador2.text == "ímpar")
               {
               texto_vencedor.text="A máquina venceu"; // tá certo
               }

            else if (escolha_mao_Jogador_1.text == "ímpar" && campo_mao_jogador2.text == "par")
              {
                texto_vencedor.text="A máquina venceu"; // tá certo
              }  

            else if (escolha_mao_Jogador_1.text == "ímpar" && campo_mao_jogador2.text == "ímpar")
              {
                texto_vencedor.text = "O jogador " + jogador_1_nome.text + "venceu"; 
              }  

            else 
              {
                texto_vencedor.text = "O jogador " + jogador_1_nome.text + " venceu";
              }   

        }

    }

}