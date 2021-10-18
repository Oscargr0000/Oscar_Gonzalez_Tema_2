using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstScript : MonoBehaviour
{
    public int x = 5;
    public int y = 2;

    public float a = 5f;
    public float b = 2f;

    public bool Isranning = false;

    public int PlayerAge = 18;



   [SerializeField] private bool HasSiren = true;



    // Start is called before the first frame update
    void Start()
    {

        /*
        Debug.Log($"Suma: {x} + {y} = {x + y}");
        Debug.Log($"Resta: {x} - {y} = {x - y}");
        Debug.Log($"Division: {x} / {y} = {x / y}");
        Debug.Log($"multiplicacion: {x} * {y} = {x * y}");

        Debug.Log(string.Format("Product: {0} / {1} = {2}", x, y, x / y));
        */

        if (Isranning == true)
        {
            Debug.Log("Lleva paraguas."); 

        } else
        {
            Debug.Log("No llueve, no lleves paraguas");
        }

        //Indicador de posesion de sirena.
        if (HasSiren)
        {

            Debug.Log($"{name} tiene sirena");
        } else
        {
            Debug.Log($"{name} no tiene sirena");
        }


        if (PlayerAge >= 18)
        {
            Debug.Log($"Eres mayor de edad");
        } else if (PlayerAge >= 13)
        {
            Debug.Log($"Eres un adolescente");
        } else
        {
            Debug.Log($"Eres un niño");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
