using UnityEngine;

public class Desafio3 : MonoBehaviour
{

    public string vogal;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        if (vogal == "a" || vogal==  "i" ||vogal == "u" ||vogal == "e" || vogal == "o" ||
            vogal == "A" || vogal==  "I" ||vogal == "U" ||vogal == "E" || vogal == "O")
        {
            Debug.Log(vogal + " é uma vogal");
        }

        else
        {
            Debug.Log("Não é uma vogal");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}