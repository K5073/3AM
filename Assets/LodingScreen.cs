using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro; // TextMeshPro를 사용하기 위한 네임스페이스
using System.Collections;

public class LoadingScreen : MonoBehaviour
{
    public Slider loadingBar;  // 로딩 바 슬라이더
    public TextMeshProUGUI loadingText; // 로딩 텍스트
    public float loadingTime = 4f; // 로딩 시간 (초)

    private void Start()
    {
        Debug.Log("Loading started."); // 로딩 시작 로그
        StartCoroutine(LoadSceneAsync("MainScene")); // 로드할 씬 이름으로 변경
    }

    private IEnumerator LoadSceneAsync(string sceneName)
    {
        // 로딩 바를 0으로 초기화
        loadingBar.value = 0f;

        // 5초 동안 로딩 진행
        for (float elapsed = 0; elapsed < loadingTime; elapsed += Time.deltaTime)
        {
            float progress = elapsed / loadingTime;
            loadingBar.value = progress;

            // 슬라이더 색상 변경 (흰색에서 노란색으로)
            Color color = Color.Lerp(Color.white, Color.yellow, progress);
            loadingBar.fillRect.GetComponent<Image>().color = color;

            yield return null; // 다음 프레임까지 대기
        }

        // 로딩이 완료되면 슬라이더 값을 1로 설정
        loadingBar.value = 1f;

        // 로딩 메시지 표시
        loadingText.text = "Press any key to continue..."; // 텍스트는 고정된 상태로 유지
        Debug.Log("Loading complete. Waiting for input..."); // 로딩 완료 로그

        // 키 입력 대기
        while (!Input.anyKeyDown)
        {
            yield return null; // 키 입력 대기
        }

        // 씬 전환
        SceneManager.LoadScene(sceneName);
    }
}
