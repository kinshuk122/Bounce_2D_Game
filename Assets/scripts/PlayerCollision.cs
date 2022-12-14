using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement pm;
    [SerializeField] private Material Material;
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Obstacle"))
        {
            pm.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
            Material.color = Color.red;
        }

        if (collision.collider.CompareTag("Gem"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
