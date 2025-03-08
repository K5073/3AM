using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; // 이 네임스페이스가 필요합니다.
using TMPro; // TextMeshPro 네임스페이스 추가

public class LobbyManager : MonoBehaviour
{
    // UI 요소를 스크립트와 연결하기 위한 변수
    public TMP_Text levelText;          // 레벨 텍스트
    public Slider levelBar;              // 경험치 바 슬라이더
    public TMP_Text coinText;            // 코인 텍스트
    public TMP_Text chLevelText;         // 캐릭터 레벨 텍스트
    public TMP_Text chNameText;          // 캐릭터 이름 텍스트

    // Start 메서드에서 초기 설정
    void Start()
    {
        // UI 요소가 null인지 확인
        if (levelText == null || levelBar == null || coinText == null || chLevelText == null || chNameText == null)
        {
            Debug.LogError("UI 요소가 연결되지 않았습니다. Inspector에서 연결해 주세요.");
            return;
        }

        InitializeUI();
    }

    // UI 초기화 메서드
    private void InitializeUI()
    {
        levelText.text = "LV.1"; // 초기 레벨 설정
        levelBar.value = 0.5f; // 초기 경험치 바 설정
        coinText.text = "Coin: 100"; // 초기 코인 수 설정
        chLevelText.text = "Lv.1"; // 캐릭터 레벨 설정
        chNameText.text = "Angel Cookie"; // 캐릭터 이름 설정
    }

    // 게임 시작 버튼 클릭 시 호출되는 메서드
    public void OnPlayButtonClicked()
    {
        SceneManager.LoadScene("MainScene"); // MainScene으로 전환
    }

    // 캐릭터 교체 버튼 클릭 시 호출되는 메서드
    public void OnCharacterChangeButtonClicked()
    {
        // 캐릭터 교체 로직 구현
    }

    // 뽑기 버튼 클릭 시 호출되는 메서드
    public void OnPickupButtonClicked()
    {
        // 뽑기 로직 구현
    }

    // 상점 버튼 클릭 시 호출되는 메서드
    public void OnStoreButtonClicked()
    {
        // 상점 로직 구현
    }
}
