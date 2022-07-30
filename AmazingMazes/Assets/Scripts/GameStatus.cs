using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStatus : MonoBehaviour
{
    // El dato miembro mScore va a estar cargada en la memoria RAM
    // todo el tiempo que dure la ejecución del programa.
    private static int mScore;
    private static int mTime;
    private static int mName;

    // Función miembro de tipo static y public para acceder al dato
    // miembro mScore.
    public static int Score { get => mScore; set => mScore = value; }
    public static int Time { get => mTime; set => mTime = value; }
    public static int Name { get => mName; set => mName = value; }


    //// No se puede instanaciaar objetos de tipo GameStatus o GlobalClass,
    //// debido a que todos sus miembros (datos y funciones) son de tipo
    //// static.
    //GameStatus Obj = new GameStatus(); // Error.
    //// La misma clase accede a sus funciones públicas de tipo static.
    //GameStatus.Score = i++;

    // Start is called before the first frame update
    void Start()
    {
        //Score = 0;
        GameStatus.Score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
