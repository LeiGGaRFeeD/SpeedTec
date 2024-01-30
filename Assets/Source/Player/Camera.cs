using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform target; // Целевой объект, за которым будет следить камера
    public int distance = 10; // Расстояние от камеры до цели
    public int height = 5; // Высота камеры над целью
    public int rotationSpeed = 5; // Скорость поворота камеры

    private float currentRotation = 0f; // Текущий угол поворота камеры
    [SerializeField] private float _cameraSpeed;

    private bool topDownOn = false;

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
    void TopDownCamera()
    {
        Debug.Log("Activated topdown");
        if (distance != 0)
        {

        }
        if (height != 90)
        {
            height++;
        }
        if (rotationSpeed != 5)
        {
            rotationSpeed++;
        }
        if (height == 90 && rotationSpeed == 5&& distance == 0 == true)
        {
            Debug.Log("Checked");
            CancelInvoke("TopDownCamera");
        }
        
    }
    void ClassicCamera()
    {
        Debug.Log("Activated classic");
        if (distance != 10)
        {
            distance--;
        }
        if (height != 5)
        {
            height--;
        }
        if (rotationSpeed != 5)
        {
            rotationSpeed--;
        }
        if (height == 5 && rotationSpeed == 5 && distance == 5)
        {
            CancelInvoke("ClassicCamera");
        }
    }
    void CameraMove(int d,int r,int h)
    {
        Debug.Log("Camera is changing");
        if (distance > d)
        {
            distance--;
        }
        if (height > h)
        {
            height--;
        }
        if (rotationSpeed > r)
        {
            rotationSpeed--;
        }
        if (distance < d)
        {
            distance++;
        }
        if (height < h)
        {
            height++;
        }
        if (rotationSpeed < r)
        {
            rotationSpeed++;
        }
        if (height == h && rotationSpeed == r && distance == d)
        {
            CancelInvoke();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<CameraTopDown>() == true)
        {
         //   distance = 0;
           // height = 90;
           // rotationSpeed = 5;
            InvokeRepeating("TopDownCamera", 0, _cameraSpeed);
        }
        
            if (other.GetComponent<CameraClassic>() == true)
            {
                //   distance = 0;
                // height = 90;
                // rotationSpeed = 5;
                InvokeRepeating("ClassicCamera", 0, _cameraSpeed);
            }
     }

}