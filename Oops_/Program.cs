using Oops_.InventoryManagment;

namespace Oops_
{
    class Program
    {
        static string inventoryFilePath = @"D:\BridgeLabz\Oops_Concept\Oops_\Inventory.json";
        static void Main(string[] args)
        {
            InventoryDetailsManagement inventoryDetailsManagement = new InventoryDetailsManagement();
            inventoryDetailsManagement.ReadJsonFile(inventoryFilePath);
        }

    }
}