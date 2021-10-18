using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
    /*
    public int playerAge = 35;
    private float playerSpeed = 5.25f;
    public string playerName = "Oscar";
    [SerializeField] private bool gameOver = false;ç


    //Variable que guarda el sonido del vehiculo

    */


    [SerializeField] private string name;
    [SerializeField] private int NumberWheels = 4;
    [SerializeField] private string Sound = "Brum, Brum";
    [SerializeField] private bool isOn = true;
    [SerializeField] private bool HasSiren = true;



    // Start is called before the first frame update
    void Start()
    {
       /*
        Debug.Log($"{name} tiene {NumberWheels} ruedas y hace {Sound}");
       */

        if (isOn == true)
        {
            Debug.Log($"{Sound}");
        } else if (HasSiren == true)
        {
            Debug.Log($"{name} hara {Sound} cuando se ponga en marcha");
        } else
        {
            Debug.Log($"{name} esta en marcha");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
