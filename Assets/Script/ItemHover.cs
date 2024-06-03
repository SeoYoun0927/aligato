using UnityEngine;
using UnityEngine.EventSystems;

public class ItemHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public OutlineEffect outlineEffect;

    public void OnPointerEnter(PointerEventData eventData)
    {
        outlineEffect.EnableOutline();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        outlineEffect.DisableOutline();
    }
}
