namespace BLL.DTOs;

public class InventoryDto
{
    public int StoreCode { get; set; }
    public string ProductName { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
}