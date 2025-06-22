using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public GameObject menuPanel;

    private bool isMenuVisible = false;

    void Start()
    {
        // ȷ����ʼ״̬Ϊ����
        menuPanel.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ToggleMenu();
        }
    }

    void ToggleMenu()
    {
        isMenuVisible = !isMenuVisible;
        menuPanel.SetActive(isMenuVisible);
        if (isMenuVisible)
        {
            Cursor.lockState = CursorLockMode.None;
        }
        else
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
    }

    public void ContinueGame()
    {
        // ʵ�ּ�����Ϸ
        Debug.Log("������Ϸ");
        menuPanel.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void QuitGame()
    {
        // ʵ���˳���Ϸ�߼�
        Debug.Log("�˳���Ϸ");
        Application.Quit();
    }
}