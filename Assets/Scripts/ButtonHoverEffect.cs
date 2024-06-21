using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ButtonHoverEffect : MonoBehaviour
{
    private TextMeshProUGUI text;
    private Color originalColor;
    public Color hoverColor = Color.yellow;

    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
        originalColor = text.color;
    }

    public void OnPointerEnter()
    {
        text.color = hoverColor;
    }

    public void OnPointerExit()
    {
        text.color = originalColor;
    }
}
