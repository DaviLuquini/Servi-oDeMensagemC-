﻿using System;
using System.Collections.Generic;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

public class SMS : IMessageService {
    
    // TODO IMPLEMENTAR O ENVIO DE SMS VIA TWILLIO
    public async Task SendMessage(string ClientMessage) {
        var sid = "AC950a72ceda1639ec7418bb4ee9fd223b";
<<<<<<< HEAD:Ioc_Di/Structure/SMS.cs
        var authToken = "99264db154e29e065147dfcecfbecaad";
=======
        var authToken = Environment.GetEnvironmentVariable("authToken");
>>>>>>> d5b489b9ff55fcfae1010ebbffde2b7fbf264684:Ioc_Di/Domain/SMS.cs
        
        Twilio.TwilioClient.SetUsername(
        username: sid
         );

        Twilio.TwilioClient.Init(
            username: sid,
            password: authToken
        );

        TwilioClient.Init(sid, authToken);

        var messageTwillio = await MessageResource.CreateAsync(
        body: ClientMessage,
            from: new Twilio.Types.PhoneNumber("+18707768331"),
            to: new Twilio.Types.PhoneNumber("+5571999163626")
        //5571999163626
        //5571981614577
        //5571988403311

        );

        Console.WriteLine("Message SID: " + messageTwillio.Sid);
        
        Console.WriteLine("Sending SMS: " + ClientMessage);
    }
}




