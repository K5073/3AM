using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;       // 이동 속도
    public float jumpForce = 20f;  // 점프 힘
    private Rigidbody2D rb;        // Rigidbody2D 변수
    private int jumpCount = 0;     // 점프 횟수 추적
    private int maxJumps = 2;      // 최대 점프 횟수

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();  // Rigidbody2D 가져오기
    }

    void Update()
    {
        // 오른쪽으로 계속 이동
        rb.linearVelocity = new Vector2(speed, rb.linearVelocity.y);

        // 스페이스바를 누르면 점프
        if (Input.GetKeyDown(KeyCode.Space) && jumpCount < maxJumps)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
            jumpCount++;  // 점프 횟수 증가
        }
    }

    // 바닥에 닿았는지 확인
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            jumpCount = 0;  // 바닥에 닿으면 점프 횟수 초기화
        }
    }
}
