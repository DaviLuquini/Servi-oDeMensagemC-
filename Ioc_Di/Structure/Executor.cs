using Ioc_Di.Domain;
using System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.TwiML.Messaging;
using Twilio.Types;


public class Executor {
    public static async Task Main() {
       
        Console.WriteLine("Write the message that you want to send:");
        String clientMessage = Console.ReadLine();
        Console.WriteLine("Which Message Service do you want to send your message? (SMS/Email)");
        String clientService = Console.ReadLine().ToUpper();

        IMessageService messageService = MessageServiceFactory.Create(clientService);

       if(messageService == null) {
            Console.WriteLine("Invalid message");
            return;
        }

       await messageService.SendMessage(clientMessage);
    }
}
/*
//Email
 IMessageService emailService = new EmailService();

       Notifier notifierViaEmail = new Notifier(emailService);

       notifierViaEmail.Notify("Hello, this is an email notification!");

       // SMS
       IMessageService smsService = new SMSService();

       Notifier notifierViaSMS = new Notifier(smsService);

       notifierViaSMS.Notify("Hello, this is an SMS notification!");

//SMS
IMessageService smsMessageService = new MessageService();

SMS Sms = new SMS();

Notifier notifierViaSMS = new Notifier(smsMessageService);

notifierViaSMS.Notify("Hello, this is an SMS notification!");
    }
*/


/* Na classe Notifier, a dependência IMessageService é injetada 
no construtor por meio da interface IMessageService. Isso permite que diferentes 
implementações da Interface, como EmailService e SMSService,
possam ser injetadas no Notifier sem modificar a classe Notifier em si. 
Isso representa a Injeção de Dependências, onde a dependência é passada de
fora da classe, invertendo o controle sobre a dependência. 

Dessa forma, a classe Notifier não precisa se preocupar com a implementação 
concreta do serviço de mensagens que está sendo usado; ela apenas usa a abstração 
definida pela interface IMensagemService. */






















