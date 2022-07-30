using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    // Crear un atributo para controlar la fuerza y la velocidad del Player.
    public float force;
    // Crear un atributo para controlar el movimiento del cuerpo rígido.
    private Rigidbody rb;

    /// <summary>
    /// Canvas (Lienzo o Formulario 2D)
    /// </summary>
    // Crear un objeto de tipo Text para manejar el tiempo.
    public Text txtTime;
    // Crear un objeto de tipo Text para manejar el puntaje.
    public Text txtScore;
    // Crear un objeto de tipo Button para reiniciar el juego.
    public Button btnReset;
    // Una bandera de tipo bool para controlar la finalización del juego.
    private bool gameOver;
    // Una variable de float para decrementar el valor del tiempo.
    private float time;
    // Una variable de tipo float para aumentar el valor del puntaje.
    // private int score;

    // Crear un objeto de tipo AudioSource para manejar el sonido.
    public AudioSource tickSource;


    // Start is called before the first frame update
    void Start()
    {
        // Obtener el cuerpo rígido del Player.
        rb = GetComponent<Rigidbody>();
        
        // Inicializar la variable tiempo con el valor de 30 seg.
        time = 100;
        gameOver = false;

        // Inicializar el valor de la variable global con cero.
        //GameStatus.Score = 0;
        //score = 0;

        // Cargando el valor de la variable global en la caja de texto 
        // txtScore.
        txtScore.text = "Puntaje: " + GameStatus.Score.ToString();
        // Hacer que el button btnReset sea invisible.
        btnReset.gameObject.SetActive(false);

        // Obtener el componente de la fuente de audio del Player.
        tickSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver != true)
        {
            // Obtener el valor de la posición en 'x' del Player.
            float h = Input.GetAxis("Horizontal");
            // Obtener el valor de la posición en 'z' del Player.
            float v = Input.GetAxis("Vertical");
            // Actualizar el valor de la posición del Vector que controla al Player.
            Vector3 vector = new Vector3(h, 0.5f, v);
            // Añadir una fuerza al cuerpo rígido para que se mueva y multiplicar
            // la fuerza por el tiempo de movimiento del último frame para 
            // obtener un movimiento continuo y fluido del Player.
            rb.AddForce(vector * force * Time.deltaTime);
            // F = m*a
            // a = (Vf-Vi)/t
            // e = v*t

            ////////Control del Canvas.
            // Asinar a la variable time lo que tiene menos el valor de 1 seg.
            // El valor de un segundo lo proporciona la función deltaTime del 
            // objeto Time.
            time -= Time.deltaTime;
            // Si el valor de la variable time es menor o igual que cero.
            if (time <= 0.0f)
            {
                // Asignar a la variable time el valor de cero.
                time = 0.0f;
                // Asignar a la bandera gameOver el valor de true.
                gameOver = true;
                // Hacer que el button btnReset sea visible.
                btnReset.gameObject.SetActive(true);
            }
            // Actualizar el valor del tiempo en la caja de texto txtTime.
            // F2 significa formato con dos decimales.
            txtTime.text = "Tiempo: " + time.ToString("F2");
        }
    }

    private void OnTriggerEnter(Collider obj)
    {
        if (obj.gameObject.tag == "coin")
        {
            // Incrementar en uno el valor del puntaje de la variable global.
            GameStatus.Score += 1;
            //score++;
            // Actualizar el valor del puntaje en la caja de texto txtScore,
            // utilizando una variable global.
            txtScore.text = "Puntaje: " + GameStatus.Score.ToString();
            //txtScore.text = "Puntaje: " + score.ToString();
            // Hacer que un coin sea invisible.
            obj.gameObject.SetActive(false);
            // Ejecutar el audio correspondiente.
            tickSource.Play();
        }

        if (obj.gameObject.tag == "bridge")
        {
            if (SceneManager.GetActiveScene().name.Equals("Scene1"))
            {
                SceneManager.LoadScene("Scene2");
            }
            else if (SceneManager.GetActiveScene().name.Equals("Scene2"))
            {
                SceneManager.LoadScene("Scene3");
            }
            else
            {
                SceneManager.LoadScene("Scene1");
            }

            //if (Application.loadedLevelName == "Scene1")
            //{
            //    Application.LoadLevel("Scene2");
            //}
            //else
            //{
            //    Application.LoadLevel("Scene1");
            //}
        }
    }

    public void ResetGame()
    {
        // Inicializar el valor de la variable global del puntaje con cero.
        GameStatus.Score = 0;
        //score = 0;
        // Inicializar el valor de la variable time con 30.
        time = 100;
        // Cargar el Nivel de Escena de la Aplicación en la que se encuentra el 
        // player. 
        //Application.LoadLevel(Application.loadedLevelName);        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
