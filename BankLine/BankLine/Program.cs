
//Aqui é um objeto de conta
using BankLine;

ContaCorrente contaDoMarcelo = new ContaCorrente();
contaDoMarcelo.titular = "Marcelo Almeida";
contaDoMarcelo.agencia = 15;
contaDoMarcelo.conta = "5541-F";
contaDoMarcelo.saldo = 350;





Console.WriteLine("O saldo da conta do " + contaDoMarcelo.titular + " é " + contaDoMarcelo.saldo);


contaDoMarcelo.Depositar(200);


Console.WriteLine("Seu novo Saldo agora é de: " + contaDoMarcelo.saldo + " R$");