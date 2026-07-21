using UnityEngine;

public class Desafio4 : MonoBehaviour
{

    public float tam1f, tam2f, tam3f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        if (tam1f == tam2f && tam1f == tam3f)
        {
            Debug.Log("Isto é um triângulo equilátero");
        }

        if (tam1f == tam2f && tam1f != tam3f || tam1f != tam2f && tam1f == tam3f || tam2f != tam1f && tam2f == tam3f)
        {
            Debug.Log("Isto é um triângulo isósceles");
        }

        if (tam1f != tam2f && tam1f != tam3f && tam3f != tam2f)
        {
            Debug.Log("Isto é um triângulo escaleno");
        }
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}