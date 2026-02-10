public class InventoryGrid 
{
    // The grid dimensions (e.g., 10x5 backpack)
    private int _width;
    private int _height;
    
    // The actual storage. null = empty, ItemData = occupied
    private InventoryItem[,] _grid; 

    public InventoryGrid(int width, int height)
    {
        _width = width;
        _height = height;
        _grid = new InventoryItem[width, height];
    }

    // CORE LOGIC: Can we place an item at (x, y)?
    public bool CheckAvailableSpace(int posX, int posY, int itemW, int itemH)
    {
        // 1. Boundary Check
        if (posX < 0 || posY < 0) return false;
        if (posX + itemW > _width || posY + itemH > _height) return false;

        // 2. Overlap Check
        for (int x = 0; x < itemW; x++)
        {
            for (int y = 0; y < itemH; y++)
            {
                if (_grid[posX + x, posY + y] != null) 
                {
                    return false; // Something is already here!
                }
            }
        }

        return true;
    }

    // PLACEMENT: Actually put it in
    public bool TryPlaceItem(InventoryItem item, int posX, int posY)
    {
        if (CheckAvailableSpace(posX, posY, item.Data.width, item.Data.height))
        {
            for (int x = 0; x < item.Data.width; x++)
            {
                for (int y = 0; y < item.Data.height; y++)
                {
                    _grid[posX + x, posY + y] = item;
                }
            }
            return true;
        }
        return false;
    }
}
