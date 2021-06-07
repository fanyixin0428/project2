using UnityEngine;
[CreateAssetMenu(fileName ="New Item", menuName = "Inventory/Item")]
public class Item : ScriptableObject
{

    new public string name = "New Item";
    public Sprite icon = null;
    public bool isDefaultItem = false;

    public virtual void Use()
    {
        Debug.Log("Using" + name);
        // Use the item
        // SOmething might happen
    }

    public void RemoveFromInventory()
    {
        Inventory.instance.Removed(this);

    }


}
