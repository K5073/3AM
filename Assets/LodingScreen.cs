using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro; // TextMeshPro�� ����ϱ� ���� ���ӽ����̽�
using System.Collections;

public class LoadingScreen : MonoBehaviour
{
    public Slider loadingBar;  // �ε� �� �����̴�
    public TextMeshProUGUI loadingText; // �ε� �ؽ�Ʈ
    public float loadingTime = 4f; // �ε� �ð� (��)

    private void Start()
    {
        Debug.Log("Loading started."); // �ε� ���� �α�
        StartCoroutine(LoadSceneAsync("MainScene")); // �ε��� �� �̸����� ����
    }

    private IEnumerator LoadSceneAsync(string sceneName)
    {
        // �ε� �ٸ� 0���� �ʱ�ȭ
        loadingBar.value = 0f;

        // 5�� ���� �ε� ����
        for (float elapsed = 0; elapsed < loadingTime; elapsed += Time.deltaTime)
        {
            float progress = elapsed / loadingTime;
            loadingBar.value = progress;

            // �����̴� ���� ���� (������� ���������)
            Color color = Color.Lerp(Color.white, Color.yellow, progress);
            loadingBar.fillRect.GetComponent<Image>().color = color;

            yield return null; // ���� �����ӱ��� ���
        }

        // �ε��� �Ϸ�Ǹ� �����̴� ���� 1�� ����
        loadingBar.value = 1f;

        // �ε� �޽��� ǥ��
        loadingText.text = "Press any key to continue..."; // �ؽ�Ʈ�� ������ ���·� ����
        Debug.Log("Loading complete. Waiting for input..."); // �ε� �Ϸ� �α�

        // Ű �Է� ���
        while (!Input.anyKeyDown)
        {
            yield return null; // Ű �Է� ���
        }

        // �� ��ȯ
        SceneManager.LoadScene(sceneName);
    }
}
