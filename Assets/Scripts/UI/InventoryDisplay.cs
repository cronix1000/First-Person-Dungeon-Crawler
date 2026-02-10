using UnityEngine;

public class InventoryDisplay : MonoBehaviour
{
    public Transform gridContainer; // The layout group
    public GameObject itemPrefab;   // The UI image of the item
    public float slotSize = 64f;    // Pixels

    private InventoryGrid _inventorySystem; // Reference to the logic

    public void RefreshDisplay()
    {
        // 1. Clear old items
        foreach (Transform child in gridContainer) Destroy(child.gameObject);

        // 2. Draw Grid (Optional background)

        // 3. Draw Items
        // Loop through the logical grid. If we find an item at (x,y) 
        // AND it's the "Top-Left" of that item, spawn the UI.
    }
}
