using Ioc_Di.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
public class Notifier {
    //Dependência armazenada no campo privado _messageService.
    private readonly IMessageService _messageService;
    // Injeção de dependecia no construtor
    public Notifier(IMessageService messageService) {
        _messageService = messageService;
    }

    public void Notify(string message) {
        _messageService.SendMessage(message);
    }
}
*/

public class Notifier {
    private readonly IMessageService _messageService;

    
    public Notifier(IMessageService messageService) {
        _messageService = messageService;
    }
    
    public void Notify(string clientMessage) {
        _messageService.SendMessage(clientMessage);
    }
}