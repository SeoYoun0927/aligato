using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager instance;

    // 인벤토리에 저장될 아이템 목록
    private List<Item> inventoryItems = new List<Item>();

    private void Awake()
    {
        // 인스턴스화된 객체가 하나뿐임을 보장
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // 아이템을 인벤토리에 추가하는 메서드
    public void AddItem(Item item)
    {
        inventoryItems.Add(item);
        // 여기에 아이템을 인벤토리 UI에 표시하는 코드를 추가할 수 있습니다.
    }

    // 아이템을 인벤토리에서 제거하는 메서드
    public void RemoveItem(Item item)
    {
        inventoryItems.Remove(item);
        // 여기에 아이템을 인벤토리 UI에서 제거하는 코드를 추가할 수 있습니다.
    }

    // 다른 스크립트에서 인벤토리 아이템에 접근하기 위한 메서드
    public List<Item> GetInventoryItems()
    {
        return inventoryItems;
    }
}
