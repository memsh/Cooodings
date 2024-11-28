using UnityEngine;
namespace Task18
{


    public class GameInventory : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Inventory potions = new Inventory();
            potions.AddItem("Healing Potion");
            potions.AddItem("Strength Potion");

            Inventory elixirs = new Inventory();
            elixirs.AddItem("Elixir");
            elixirs.AddItem("Dark Elixir");

            Inventory combinedInventory = potions + elixirs;
            combinedInventory.ShowItems();

        }


    }
}
