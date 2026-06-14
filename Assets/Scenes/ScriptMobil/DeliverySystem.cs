using UnityEngine;
using UnityEngine.SceneManagement;

public class DeliverySystem : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            int nextScene = SceneManager.GetActiveScene().buildIndex + 1;

            SceneManager.LoadScene(nextScene);
        }
    }
}