using UnityEngine;

public class ShootyGunScript3D : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab; // Prefab for the bullet
    [SerializeField] private float bulletSpeed = 20f; // Speed of the bullet
    [SerializeField] private float bulletLifetime = 5f; // Time before the bullet is destroyed

    private void Update()
    {
        // Shoot when the left mouse button is released
        if (Input.GetMouseButtonUp(0))
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        // Instantiate the bullet at the camera's position and orientation
        GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
        bullet.SetActive(true);

        // Add velocity in the forward direction of the camera
        Rigidbody bulletRb = bullet.GetComponent<Rigidbody>();
        bulletRb.velocity = transform.forward * bulletSpeed;

        // Destroy the bullet after a certain time
        Destroy(bullet, bulletLifetime);
    }
}