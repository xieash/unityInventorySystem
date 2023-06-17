using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Color hoverColor;

    private Button button;
    private Image image;
    private Color normalColor;

    public float hoverScale = 1.1f;

    private RectTransform rectTransform;
    private Vector3 normalScale;

    void Awake()
    {
        button = GetComponent<Button>();
        image = button.GetComponent<Image>();
        rectTransform = GetComponent<RectTransform>();
        normalColor = image.color;
        normalScale = rectTransform.localScale;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        image.color = hoverColor;
        rectTransform.localScale = normalScale * hoverScale;
        
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        image.color = normalColor;
        rectTransform.localScale = normalScale;
        
    }
}