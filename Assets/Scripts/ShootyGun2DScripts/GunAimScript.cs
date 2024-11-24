using UnityEngine;

public class GunAimScript : MonoBehaviour
{
    private Camera mainCamera;

    private void Start()
    {
        mainCamera = Camera.main;
    }

    private void Update()
    {
        Vector3 mousePosition = Input.mousePosition;
        Vector3 gunPosition = mainCamera.WorldToScreenPoint(transform.position);
        Vector2 direction = mousePosition - gunPosition;
        float rot = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0, 0, rot);
    }
}