using UnityEngine;
using UnityEngine.UI;

public class ResizeButton : MonoBehaviour
{
    private Button button;
    private Vector2 originalSize;

    void Start()
    {
        button = GetComponent<Button>();
        originalSize = button.GetComponent<RectTransform>().sizeDelta;
        button.onClick.AddListener(OnClick);
    }

    void OnClick()
    {
        // Decrease size
        button.GetComponent<RectTransform>().sizeDelta *= 0.95f;

        // Invoke a method to restore the size after a delay
        Invoke("RestoreSize", 0.1f);
    }

    void RestoreSize()
    {
        // Restore original size
        button.GetComponent<RectTransform>().sizeDelta = originalSize;
    }
}
