using DesafioPOO.Models;
Console.WriteLine("Bem vindo à Loja Cell \nEscolha uma opção\n");
Console.WriteLine("----------\nA - Nokia \nB - Iphone\n----------");
string texto = Console.ReadLine();
string escolha = texto.ToUpper();

switch (escolha)
{
case "A": 
Console.WriteLine("Informe o número:");
string NokiaNumero = Console.ReadLine();
Console.WriteLine("Informe o modelo:");
string NokiaModelo = Console.ReadLine();
Console.WriteLine("Informe o imei:");
string NokiaImei = Console.ReadLine();
Console.WriteLine("Informe a memória:");
int NokiaMemoria = int.Parse(Console.ReadLine());

Smartphone nokia = new Nokia(numero: NokiaNumero ,modelo: NokiaModelo, imei: NokiaImei, memoria: NokiaMemoria);
nokia.DadosCelular();
nokia.Ligar();
nokia.InstalarAplicativo("Play Store");
break;
case "B":
Console.WriteLine("Informe o número:");
string IphoneNumero = Console.ReadLine();
Console.WriteLine("Informe o modelo:");
string IphoneModelo = Console.ReadLine();
Console.WriteLine("Informe o imei:");
string Iphoneimei = Console.ReadLine();
Console.WriteLine("Informe a memória:");
int IphoneMemoria = int.Parse(Console.ReadLine());

Console.WriteLine("\nTelefone Iphone");
Smartphone iphone = new Iphone(numero: IphoneNumero, modelo: IphoneModelo, imei: Iphoneimei, memoria: IphoneMemoria);
iphone.DadosCelular();
iphone.Ligar();
iphone.InstalarAplicativo("App Store");
break;
default:Console.WriteLine("Opção não implementada. Escolha 'A' para Nokia ou 'B' para Iphone");
break;
}