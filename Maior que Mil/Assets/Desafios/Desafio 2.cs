using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Desafio2 : MonoBehaviour
{

    public int numero_1 = 0;

    public int numero_2 = 0;

    public int numero_3 = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        if (numero_1 > numero_2 && numero_1 > numero_3)
        {
            Debug.Log("O maior número é " + numero_1);
        }

        if (numero_2 > numero_1 && numero_2 > numero_3)
        {
            Debug.Log("O maior número é " + numero_2);
        }

        if (numero_3 > numero_1 && numero_3 > numero_2)
        {
            Debug.Log("O maior número é " + numero_3);
        }

        if (numero_1 == numero_2 && numero_1 == numero_3)
        {
            Debug.Log("Todos os números são iguais");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}