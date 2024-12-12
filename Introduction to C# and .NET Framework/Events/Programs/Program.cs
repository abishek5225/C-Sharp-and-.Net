public class Doorbell{
    public delegate void RingEventHandler(string message);

    public event RingEventHandler Ring;

    public void PressedButton(){
        Console.Writeline("Doorbell is pressed");

        Ring?Invoke("Someone is Ringing doorbell");
    }
}
public class AlertSystem{
    public void OnRing(string message){
        Console.WriteLine($"Alert: {message}");
    }
}
public class Program{
    public static void Main(){
        Doorbell doorbell= new Doorbell();

        AlertSystem alert=new AlertSystem();

        doorbell.Ring +=alert.OnRing;
        doorbell.PressedButton();
    }
}