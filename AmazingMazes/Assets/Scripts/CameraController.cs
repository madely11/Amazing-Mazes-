using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Objeto de tipo GameObject para enlazar la cámara con el player.
    public GameObject player;
    // Vector3 para obtener la posición inicial de la cámara.
    private Vector3 posInitial;

    // Start is called before the first frame update
    void Start()
    {
        // Obtener un Vector3 perpendicular entre la cámara (camera) y el jugador (player).
        posInitial = this.transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // Obtener un Vector3 de seguimiento al jugador (player).
        this.transform.position = player.transform.position + posInitial;
    }
}
