using UnityEngine;

public class Desafio7 : MonoBehaviour
{

    private int recurso_jogador = 0;
    private int quantidade_click_recurso = 1;

    public void clique()
    {
        recurso_jogador += quantidade_click_recurso;
        Debug.Log("Você tem: " + recurso_jogador + " de recursos");
        
    } 

    public void upgrade1()
    {
        if (recurso_jogador < 30)
        {
            int faltaup1 = 30 - recurso_jogador;
            Debug.Log("Faltam " + faltaup1 + " para você usar este upgrade");

        }

        else
        {
        recurso_jogador -= 30;
        quantidade_click_recurso *= 2;
        Debug.Log("Upgrade comprado! Agora você ganha " + quantidade_click_recurso + " por clique");
        }
    }

    public void upgrade2()
    {
        if(recurso_jogador < 100)
        {
            int faltaup2 = 100 - recurso_jogador;
            Debug.Log("Faltam " + faltaup2 + "para você usar este upgrade");
        }

        else
        {
            recurso_jogador-=100;
            quantidade_click_recurso = quantidade_click_recurso*0;
            quantidade_click_recurso = quantidade_click_recurso + 1;
            quantidade_click_recurso = quantidade_click_recurso*5;
            Debug.Log("Upgrade comprado! Agora você ganha " + quantidade_click_recurso + " por clique");
        }
        }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
