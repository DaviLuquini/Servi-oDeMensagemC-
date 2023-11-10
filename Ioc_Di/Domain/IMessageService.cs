using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IMessageService {
    public Task SendMessage(string message);

    /*TODO IMPLEMENTAR UMA FABRICA DE ENVIO DE MENSAGEM ONDE O CHAMADO PASSA O TIPO QUE PODE SER UMA STRING  EX SMS OR EMAIL
        CRIAR UM CONSOLE ONDE O CLIENTE INFORMA A MENSAGEM E O TIPO DE ENVIO, FIXAR UM NUMERO DE TELEFONE PARA SMS */
}
