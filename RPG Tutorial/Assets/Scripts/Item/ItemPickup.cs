
using UnityEngine;

public class ItemPickup : Interactable
{

    public Item item;

    public override void Interact()
    {
        base.Interact();

        PickUp();

    }

    void PickUp()
    {
       
        Debug.Log("Picking up "+ item.name);
        bool wasPickedUP = Inventory.instance.Add(item);
        //Add to inventory
        if(wasPickedUP)
            Destroy(gameObject);
    }
}
