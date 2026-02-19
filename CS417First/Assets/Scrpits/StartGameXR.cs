using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class StartToGameScene : MonoBehaviour
{
    public InputActionReference rightPrimaryButton;
    public string mainGameSceneName = "MainGameScene";

    bool loading = false;

    void OnEnable()
    {
        rightPrimaryButton.action.Enable();
        rightPrimaryButton.action.performed += OnPressed;
    }

    void OnDisable()
    {
        rightPrimaryButton.action.performed -= OnPressed;
    }

    void OnPressed(InputAction.CallbackContext ctx)
    {
        if (loading) return;
        loading = true;

        SceneManager.LoadScene(mainGameSceneName);
    }
}
