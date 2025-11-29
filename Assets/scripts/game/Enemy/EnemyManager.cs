using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyManager : MonoBehaviour
{
    // CANTIDAD DE ESCENAAAAAAAAAAAAAAAASSSSSSSSSSSSSS
    private int lastSceneIndex = 5;

    void Update()
    {
        // BUSCADOR DE ENEMIGOOOOOOOOSHHHHHHHHHHHHHHH
        EnemyMovement[] enemies = FindObjectsOfType<EnemyMovement>();

        // SI TODOS SE MURIEROOON XP
        if (enemies.Length == 0)
        {
            int currentScene = SceneManager.GetActiveScene().buildIndex;

            // Solo avanzar si NO estamos ya en la última escena
            if (currentScene < lastSceneIndex)
            {
                SceneManager.LoadScene(currentScene + 1);
            }
            else
            {
                Debug.Log("🎉 Llegaste a la última escena, no se avanza más.");
            }
        }
    }
}


