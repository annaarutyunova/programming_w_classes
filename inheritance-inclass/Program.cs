void Main()
{
    Phone phone = new Phone(8015);

    CameraPhone camera = new CameraPhone(8015);

    camera.PlaceCall(801);


}

Main();



public class Phone
{
    private int phoneNumber = 0;
    List<string> textMessages = new List<string>();

    public void PlaceCall(int numberToCall)
    {
        Console.WriteLine(numberToCall);
    }

    public void PlaceText(int numberToText, string messageToSend)
    {
       
    }

    public void SaveText(string messageToSave)
    {

    }
    public void getTexts()
    {

    }

    public void getNumber()
    {

    }
    
    public Phone(int phoneNumber)
    {
        this.phoneNumber = phoneNumber;
    }

}

public class CameraPhone : Phone {
    List<string> pictures = new List<string>();
    
    public void TakePicture(string picture_name)
    {
        pictures.Add(picture_name);
    }

    public CameraPhone(int phoneNumber) : base(phoneNumber)
    {

    }
}




