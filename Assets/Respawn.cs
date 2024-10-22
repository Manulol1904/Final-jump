using UnityEngine;

public class Respawn : MonoBehaviour
{
    // Referencia a la posición de respawn (puedes asignar esta posición desde el Inspector)
    public Transform respawnPoint;
    // Referencia al jugador
    public GameObject player;

    // Método que se llama cuando el jugador toca un objeto que lo mata (como los pinchos)
    public void RespawnPlayer()
    {
        // Mueve al jugador a la posición de respawn
        player.transform.position = respawnPoint.position;
    }
}

