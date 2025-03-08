using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player;  // 플레이어의 Transform
    public float smoothing = 5f;  // 카메라 이동 부드럽게
    public float fixedHeight = 0f; // 고정할 카메라 높이 (y값)

    private Vector3 offset;  // 플레이어와 카메라 간의 거리

    void Start()
    {
        // 플레이어와 카메라 간의 초기 거리 계산
        offset = transform.position - player.position;
    }

    void FixedUpdate()
    {
        // 카메라가 플레이어를 따라가게 하되, y값은 고정
        Vector3 targetCamPos = player.position + offset;
        targetCamPos.y = fixedHeight; // 카메라 y 고정

        // 카메라 부드럽게 이동
        transform.position = Vector3.Lerp(transform.position, targetCamPos, smoothing * Time.deltaTime);
    }
}
