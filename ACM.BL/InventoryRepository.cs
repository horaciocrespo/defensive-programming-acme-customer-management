using System;

namespace ACM.BL
{
    public class InventoryRepository
    {
        public void OrderItems(Order order, bool allowSplitOrders)
        {
            // -- Order the items from inventory --
            // For each item ordered,
            // Locate the item in inventory.
            // If no longer available, notify the user.
            // If any items are back ordered and the customer does not
            // want to split orders,
            // notify the user.
            // If the item is available,
            // Decrement the quantity remaining.
            // Open a connection
            // Set a stored procedure parameter with the inventory data.
            // Call the save stored procedure.
        }
    }
}