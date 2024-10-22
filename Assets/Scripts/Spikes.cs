using UnityEngine;

public class Spikes : MonoBehaviour
{
    public Respawn respawn;  // Referencia al script de respawn

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Si el jugador toca los pinchos
        if (collision.CompareTag("Player"))
        {
            // Llamar al método de respawn para mover al jugador
            respawn.RespawnPlayer();
        }
    }
}

