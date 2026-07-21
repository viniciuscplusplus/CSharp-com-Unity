using UnityEngine;

public class Desafio1 : MonoBehaviour
{

    public int x, y;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int resultado = x + y;
        Debug.Log("A soma de " + x + " e " + y + " é igual a " + resultado);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}