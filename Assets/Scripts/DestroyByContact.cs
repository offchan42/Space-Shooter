using UnityEngine;

public class DestroyByContact : MonoBehaviour
{
    public GameObject explosionPrefab;
    public GameObject playerExplosionPrefab;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Boundary"))
        {
            return;
        }
        if (other.CompareTag("Player"))
        {
            Instantiate(playerExplosionPrefab, other.transform.position, other.transform.rotation);
        }
        Instantiate(explosionPrefab, transform.position, transform.rotation);
        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}