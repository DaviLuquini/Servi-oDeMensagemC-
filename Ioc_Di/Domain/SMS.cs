using System;
using System.Collections.Generic;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

public class SMS : IMessageService {
    public string ClientMessage;
    // TODO IMPLEMENTAR O ENVIO DE SMS VIA TWILLIO
    public void SendMessage(string ClientMessage) {
        var sid = "AC950a72ceda1639ec7418bb4ee9fd223b";
        var authToken = Environment.GetEnvironmentVariable("authToken");
        
        Twilio.TwilioClient.SetUsername(
        username: sid
         );

        Twilio.TwilioClient.Init(
            username: sid,
            password: authToken
        );

        TwilioClient.Init(sid, authToken);

        var messageTwillio = MessageResource.Create(
        body: ClientMessage,
            from: new Twilio.Types.PhoneNumber("+18707768331"),
            to: new Twilio.Types.PhoneNumber("+5571999953896")
        //5571999163626
        //5571999953896
        );

        Console.WriteLine("Message SID: " + messageTwillio.Sid);
        
        Console.WriteLine("Sending SMS: " + ClientMessage);
    }
}




