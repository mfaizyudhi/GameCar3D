using UnityEngine;

public class PackagePickup : MonoBehaviour
{
    public GameObject deliveryPoint;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Debug.Log("Package Picked!");

            deliveryPoint.SetActive(true);

            gameObject.SetActive(false);
        }
    }
}