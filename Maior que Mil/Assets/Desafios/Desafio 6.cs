using UnityEngine;

public class Desafio6 : MonoBehaviour
{

    public int num1, num2, num3;

    bool maiorquemil(int num1, int num2, int num3)
    {
        if ((num1+num2)*num3 > 1000)
        {
            return true;
        }

        else
        {
            return false;
        }

    }


    void Start()
    {
      bool resultado = maiorquemil(num1,num2,num3);

      Debug.Log(resultado);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}