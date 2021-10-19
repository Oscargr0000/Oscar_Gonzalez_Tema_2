using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstScript : MonoBehaviour
{
    public int x = 5;
    public int y = 2;

    /*public float a = 5f;
    public float b = 2f;*/

    //Indica el nombre 
    [SerializeField] private string name;
    [SerializeField] private int NumberWheels = 4;
    [SerializeField] private string Sound = "Brum, Brum";
    [SerializeField] private bool isOn = true;
    [SerializeField] private bool HasSiren = true;


    public bool Isranning = false;
    public bool iscold;

    public int PlayerAge = 18;
    [SerializeField] private float gasoline;


    // Start is called before the first frame update
    void Start()
    {
        /*
        if (x == 2 && y <= 7)
        {
            Debug.Log($"Verdadero");
        }else
        {
            Debug.Log($"Falso");
        }*/



        if (isOn == true)
        {
           Debug.Log($"¡A {name} le queda poca gasolina!");

            if (HasSiren == true)
            {
                Debug.Log($"{Sound}");
            }
            else
            {
                Debug.Log($"{name} no tiene sirena");
            }
         
        }


        /*
        if (Isranning == true)
        {
            if (iscold == true)
            {
                Debug.Log("Lleva paraguas y sudadera.");
            }
            else
            {
                Debug.Log("Lleva paraguas.");
            }
            

        }
        else
        {
            if (iscold == true)
            {
                Debug.Log($"Lleva una sudadera");
            }
            else
            {
                Debug.Log($"disfruta del dia");
            }
           Debug.Log("No llueve, no lleves paraguas");
        }
        */






        /*
        Debug.Log($"Suma: {x} + {y} = {x + y}");
        Debug.Log($"Resta: {x} - {y} = {x - y}");
        Debug.Log($"Division: {x} / {y} = {x / y}");
        Debug.Log($"multiplicacion: {x} * {y} = {x * y}");

        Debug.Log(string.Format("Product: {0} / {1} = {2}", x, y, x / y));
        */



        //Indicador de posesion de sirena.
        /*
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
        }*/

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
