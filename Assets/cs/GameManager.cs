using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject pauseMenu; // PauseMenu �г�

    private bool isPaused = false;

    private void Start()
    {
        // ���� ���� �� pauseMenu�� ��Ȱ��ȭ
        pauseMenu.SetActive(false);
    }


    private void Update()
    {
        // ESC Ű �Է� ����
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
        Time.timeScale = 0; // ���� �Ͻ� ����
        pauseMenu.SetActive(true); // PauseMenu ǥ��
        Debug.Log("Game Paused"); // �α� �߰�
    }

    public void ResumeGame()
    {
        isPaused = false;
        Time.timeScale = 1; // ���� �簳
        pauseMenu.SetActive(false); // PauseMenu ����
    }

    public void LoadLobby()
    {
        Time.timeScale = 1; // ���� �簳
        SceneManager.LoadScene("LobbyScene"); // �κ� ������ �̵�
    }

    public void RestartGame()
    {
        Time.timeScale = 1; // ���� �簳
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // ���� �� �����
    }
}
