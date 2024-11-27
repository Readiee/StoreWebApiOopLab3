namespace BLL.DTOs;

public class PurchaseDto
{
    public int StoreCode { get; set; }
    public Dictionary<string, int> ProductsToBuy { get; set; }
}