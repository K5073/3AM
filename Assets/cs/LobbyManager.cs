using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; // �� ���ӽ����̽��� �ʿ��մϴ�.
using TMPro; // TextMeshPro ���ӽ����̽� �߰�

public class LobbyManager : MonoBehaviour
{
    // UI ��Ҹ� ��ũ��Ʈ�� �����ϱ� ���� ����
    public TMP_Text levelText;          // ���� �ؽ�Ʈ
    public Slider levelBar;              // ����ġ �� �����̴�
    public TMP_Text coinText;            // ���� �ؽ�Ʈ
    public TMP_Text chLevelText;         // ĳ���� ���� �ؽ�Ʈ
    public TMP_Text chNameText;          // ĳ���� �̸� �ؽ�Ʈ

    // Start �޼��忡�� �ʱ� ����
    void Start()
    {
        // UI ��Ұ� null���� Ȯ��
        if (levelText == null || levelBar == null || coinText == null || chLevelText == null || chNameText == null)
        {
            Debug.LogError("UI ��Ұ� ������� �ʾҽ��ϴ�. Inspector���� ������ �ּ���.");
            return;
        }

        InitializeUI();
    }

    // UI �ʱ�ȭ �޼���
    private void InitializeUI()
    {
        levelText.text = "LV.1"; // �ʱ� ���� ����
        levelBar.value = 0.5f; // �ʱ� ����ġ �� ����
        coinText.text = "Coin: 100"; // �ʱ� ���� �� ����
        chLevelText.text = "Lv.1"; // ĳ���� ���� ����
        chNameText.text = "Angel Cookie"; // ĳ���� �̸� ����
    }

    // ���� ���� ��ư Ŭ�� �� ȣ��Ǵ� �޼���
    public void OnPlayButtonClicked()
    {
        SceneManager.LoadScene("MainScene"); // MainScene���� ��ȯ
    }

    // ĳ���� ��ü ��ư Ŭ�� �� ȣ��Ǵ� �޼���
    public void OnCharacterChangeButtonClicked()
    {
        // ĳ���� ��ü ���� ����
    }

    // �̱� ��ư Ŭ�� �� ȣ��Ǵ� �޼���
    public void OnPickupButtonClicked()
    {
        // �̱� ���� ����
    }

    // ���� ��ư Ŭ�� �� ȣ��Ǵ� �޼���
    public void OnStoreButtonClicked()
    {
        // ���� ���� ����
    }
}
