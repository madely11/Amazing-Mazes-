using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStatus : MonoBehaviour
{
    // El dato miembro mScore va a estar cargada en la memoria RAM
    // todo el tiempo que dure la ejecución del programa.
    private static int mScore;
    private static float mTime;
    private static string mName;

    // Función miembro de tipo static y public para acceder al dato
    // miembro mScore.
    public static int Score { get => mScore; set => mScore = value; }
    public static string Name { get => mName; set => mName = value; }
    public static float Time { get => mTime; set => mTime = value; }



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
        GameStatus.Time = 0;
        GameStatus.Name = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
