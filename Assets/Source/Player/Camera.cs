using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform target; // Целевой объект, за которым будет следить камера
    public float distance = 10f; // Расстояние от камеры до цели
    public float height = 5f; // Высота камеры над целью
    public float rotationSpeed = 5f; // Скорость поворота камеры

    private float currentRotation = 0f; // Текущий угол поворота камеры

    void LateUpdate()
    {
        if (target == null)
            return;

        // Рассчитываем позицию камеры
        Vector3 targetPosition = target.position - target.forward * distance + Vector3.up * height;
        transform.position = targetPosition;

        // Поворачиваем камеру вокруг цели
        currentRotation += Input.GetAxis("Mouse X") * rotationSpeed;
        Quaternion rotation = Quaternion.Euler(0f, currentRotation, 0f);
        transform.rotation = rotation;

        // Направляем камеру на цель
        transform.LookAt(target);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<CameraTopDown>() == true)
        {
            distance = 0;
            height = 90;
            rotationSpeed = 5;
        }
    }
}