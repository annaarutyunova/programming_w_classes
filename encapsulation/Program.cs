VendingMachine v = new VendingMachine();
// Console.WriteLine(v.items); this wouldn't work because items in private
v.Populate();
v.getlList();
public class Item {
    private string name;
    private double price;
    private string location;

    private int quantity; 

    public Item(string name, double price, string location, int quantity = 1) {
        this.name = name;
        this.price = price;
        this.location = location;
    }

    private double totalValue() {
        return quantity * price;

    }

    public void showItem() {
        Console.WriteLine($"{name} - {price} - {location} - QTY: {quantity}");
        Console.WriteLine($"Total Value: {totalValue()}");
    }

}

public class VendingMachine {
    public List<Item> items = new List<Item>();

    public VendingMachine (){
        Console.WriteLine("it's working");
    }
    
    public void Populate() {
        items.Add(new Item("Doritos", 2.5, "A3"));
        items.Add(new Item("Reeses", 0.75, "A4"));
        items.Add(new Item("Granola Bar", 1.25, "A5"));
        

    }

    public void getlList() {
        foreach(Item item in items) {
        item.showItem();
        }
    }

}