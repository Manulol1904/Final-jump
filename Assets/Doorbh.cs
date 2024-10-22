using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // Cargar la siguiente escena o mostrar un mensaje
            Debug.Log("Nivel completado!");
            // Puedes usar SceneManager.LoadScene("NombreDeLaSiguienteEscena") para cambiar de nivel
        }
    }
}
