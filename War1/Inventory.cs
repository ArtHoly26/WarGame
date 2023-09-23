namespace War1
{
    class InventoryItem
    {
        public string? Name { get; set; }
        public int Quantity { get; set; }
        public bool IsEquipped { get; set; }
    }
   class Inventory
   {
        private List<InventoryItem> items;
        public Inventory()
        {
            items = new List<InventoryItem>();
        }
        public void AddItem(string name, int quantity)
        {
            InventoryItem existingItem = items.Find(item => item.Name == name);

            if (existingItem != null)
            {
                existingItem.Quantity += quantity;
            }
            else
            {
                items.Add(new InventoryItem { Name = name, Quantity = quantity });
            }
        }
        public void RemoveItem(string name, int quantity)
        {
            InventoryItem existingItem = items.Find(item => item.Name == name);

            if (existingItem != null)
            {
                existingItem.Quantity -= quantity;

                if (existingItem.Quantity <= 0)
                {
                    items.Remove(existingItem);
                }
            }
        }
        public void EquipItem(string name)
        {
            InventoryItem existingItem = items.Find(item => item.Name == name);

            if (existingItem != null)
            {
                existingItem.IsEquipped = true;
            }
        }
        public void UnequipItem(string name)
        {
            InventoryItem existingItem = items.Find(item => item.Name == name);

            if (existingItem != null)
            {
                existingItem.IsEquipped = false;
            }
        }
        public void ShowInventory()
        {
            foreach(InventoryItem item in items)
            {
                string equippedText = item.IsEquipped ? " [EQUIPPED]" : "";
                Console.WriteLine($"{item.Name} x{item.Quantity}{equippedText}");
            }
        }
        public void UseItem(string name)
        {
            InventoryItem existingItem = items.Find(item => item.Name == name);

            if (existingItem != null)
            {
                Console.WriteLine($"Using {name}...");
                // Здесь должна быть логика использования предмета
            }
        }


    }
}
