using System.Collections;
using UnityEngine;

public class DisappearingPlatform : MonoBehaviour
{
    public float timeOnPlatform = 3f; // Tiempo que el jugador puede estar sobre la plataforma
    public float reappearTime = 3f; // Tiempo que tarda la plataforma en reaparecer

    private bool isPlayerOnPlatform = false; // Controla si el jugador está en la plataforma
    private Collider2D platformCollider;
    private SpriteRenderer platformRenderer;

    private void Start()
    {
        // Obtén el componente Collider y Renderer
        platformCollider = GetComponent<Collider2D>();
        platformRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player") && !isPlayerOnPlatform)
        {
            isPlayerOnPlatform = true;
            StartCoroutine(DisappearAndReappear());
        }
    }

    private IEnumerator DisappearAndReappear()
    {
        yield return new WaitForSeconds(timeOnPlatform); // Espera antes de desaparecer
        platformRenderer.enabled = false; // Desactiva el SpriteRenderer para que desaparezca visualmente
        platformCollider.enabled = false; // Desactiva el Collider para que no se pueda tocar

        yield return new WaitForSeconds(reappearTime); // Espera antes de reaparecer
        platformRenderer.enabled = true; // Reactiva el SpriteRenderer
        platformCollider.enabled = true; // Reactiva el Collider

        isPlayerOnPlatform = false; // Resetea el estado
    }
}


