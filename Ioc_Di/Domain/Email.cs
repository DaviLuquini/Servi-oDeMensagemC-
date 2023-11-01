using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//TODO FAZER ENVIO DE EMAIL VIA SES DA AMAZON 
public class Email : IMessageService {

    public string ClientMessage;
    public void SendMessage(string ClientMessage) {
        Console.WriteLine("Sending email: " + ClientMessage);
    }
}