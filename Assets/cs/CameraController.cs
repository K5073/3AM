using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player;  // �÷��̾��� Transform
    public float smoothing = 5f;  // ī�޶� �̵� �ε巴��
    public float fixedHeight = 0f; // ������ ī�޶� ���� (y��)

    private Vector3 offset;  // �÷��̾�� ī�޶� ���� �Ÿ�

    void Start()
    {
        // �÷��̾�� ī�޶� ���� �ʱ� �Ÿ� ���
        offset = transform.position - player.position;
    }

    void FixedUpdate()
    {
        // ī�޶� �÷��̾ ���󰡰� �ϵ�, y���� ����
        Vector3 targetCamPos = player.position + offset;
        targetCamPos.y = fixedHeight; // ī�޶� y ����

        // ī�޶� �ε巴�� �̵�
        transform.position = Vector3.Lerp(transform.position, targetCamPos, smoothing * Time.deltaTime);
    }
}
