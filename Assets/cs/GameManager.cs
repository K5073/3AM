using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject pauseMenu; // PauseMenu 패널

    private bool isPaused = false;

    private void Start()
    {
        // 게임 시작 시 pauseMenu를 비활성화
        pauseMenu.SetActive(false);
    }


    private void Update()
    {
        // ESC 키 입력 감지
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    public void PauseGame()
    {
        isPaused = true;
        Time.timeScale = 0; // 게임 일시 정지
        pauseMenu.SetActive(true); // PauseMenu 표시
        Debug.Log("Game Paused"); // 로그 추가
    }

    public void ResumeGame()
    {
        isPaused = false;
        Time.timeScale = 1; // 게임 재개
        pauseMenu.SetActive(false); // PauseMenu 숨김
    }

    public void LoadLobby()
    {
        Time.timeScale = 1; // 게임 재개
        SceneManager.LoadScene("LobbyScene"); // 로비 씬으로 이동
    }

    public void RestartGame()
    {
        Time.timeScale = 1; // 게임 재개
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // 현재 씬 재시작
    }
}
