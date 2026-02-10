using UnityEngine;

[CreateAssetMenu(fileName = "NewItem", menuName = "Game/Item")]
public class ItemData : ScriptableObject
{
    public string id;
    public string itemName;
    public Sprite icon;
    
    [Header("Spatial Logic")]
    [Range(1, 10)] public int width = 1;  // How many columns it takes
    [Range(1, 10)] public int height = 1; // How many rows it takes
    public bool canRotate = true;
    
    [Header("Simulation Stats")]
    public float weight; // Affects player speed
}
