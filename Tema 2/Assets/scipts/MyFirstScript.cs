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
    public string hello;
    public int number1;
    public int number2;
    
    // Start is called before the first frame update
    void Start()
    {
        // HelloWorld();
        //hello = GetHello();
        //Debug.Log(GetHello());

        Debug.Log(Producto(number1, number2));
        

       /*
        if (x == 2 && y <= 7)
        {
            Debug.Log($"Verdadero");
        }else
        {
            Debug.Log($"Falso");
        }



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
        






       
        Debug.Log($"Suma: {x} + {y} = {x + y}");
        Debug.Log($"Resta: {x} - {y} = {x - y}");
        Debug.Log($"Division: {x} / {y} = {x / y}");
        Debug.Log($"multiplicacion: {x} * {y} = {x * y}");

        Debug.Log(string.Format("Product: {0} / {1} = {2}", x, y, x / y));
        



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
        }*/

    }

    // Update is called once per frame
    void Update()
    {
        //MOVIMIENTO
        MovementToDirection(KeyCode.D, Vector3.right);
        MovementToDirection(KeyCode.A, Vector3.left);
        MovementToDirection(KeyCode.W, Vector3.forward);
        MovementToDirection(KeyCode.S, Vector3.back);
        MovementToDirection(KeyCode.Q, Vector3.down);
        MovementToDirection(KeyCode.Space, Vector3.up);

        //ROTACION  
        rotationdirection(KeyCode.RightArrow, new Vector3(0, 10, 0));
        rotationdirection(KeyCode.LeftArrow, new Vector3(0, -10, 0));

        //ESCALADO
        Escalado(KeyCode.R, Vector3.right);
       

        if (isOn == true)
        {
            if (Input.GetKeyDown(KeyCode.D))
            {
                transform.position += Vector3.right;
            }

            if (Input.GetKeyDown(KeyCode.A))
            {
                transform.position += Vector3.left;
            }

            if (Input.GetKeyDown(KeyCode.Q))
            {
                transform.position += Vector3.down;
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                transform.position += Vector3.up;
            }

            if (Input.GetKeyDown(KeyCode.W))
            {
                transform.position += Vector3.forward;
            }

            if (Input.GetKeyDown(KeyCode.S))
            {
                transform.position += Vector3.back;
            }
        }
    }

    public void HelloWorld()
    {
        Debug.Log("Hola, Mundo");
    }

    public string GetHello()
    {
        return "hola";
    }

    //FUNCION DE MOVIMIENTO
    public void MovementToDirection(KeyCode key, Vector3 Direction)
    {
        if (Input.GetKeyDown(key))
        {
            transform.position += Direction;
        }
    }

    //FUNCION DE ESCALADO
    public void Escalado(KeyCode key, Vector3 Scale)
    {
        if (Input.GetKeyDown(key))
        {
            transform.localScale += Scale;
        }
    }
    //ROTATION
    public void rotationdirection(KeyCode key, Vector3 rotation)
    {
        if (Input.GetKeyDown(key))
        {
            transform.position += rotation;
        }
    }

    public int Producto(int num1, int num2)
    {
        return num1 * num2;
    }
}
