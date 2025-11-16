//exercício: 1 programa que calcule valores de retenção para IRS e Segurança Social de um determinado funcionário.
//Admita que as taxas de retenção para o IRS são de 15% e para a SS de 12%. Calcule e apresente o valor da retenção e salário líquido


/*double salario = 0;
const double irs = 0.15;
const double ss = 0.12;
double valorirs, valorss = 0;

Console.WriteLine("Indique o valor do salário: ");
salario = double.Parse(Console.ReadLine());

valorirs = salario * irs;
valorss = salario * ss;

salario = salario - valorirs - valorss;

Console.WriteLine("O funcionário vai recever {0} euros líquidos. Vai reter {1} euros de IRS e {2} euros para a Segurança Social.", salario, valorirs, valorss);

Console.ReadKey();*/

//exercício: 1 programa que calcule o consumo de combustível de um automóvel (por 100 km) e o valor da desspesa da viagem.
//O programa deverá solicitar, para além do consumo registado e dos kms percorridos, o preço atual do combustível.

/*double consumo = 0, kms = 0, preco = 0;

Console.WriteLine("Indique os kms percorridos: ");
kms = double.Parse(Console.ReadLine());

Console.WriteLine("Indique o consumo registado: ");
consumo = double.Parse(Console.ReadLine());

Console.WriteLine("Indique o preço do combustível: ");
preco = double.Parse(Console.ReadLine());

double consumokms, despesa;

consumokms = consumo / kms * 100;
despesa = preco * consumo;

Console.WriteLine("Consumo de {0}/100 kms e gastou {1} euros.", consumokms, despesa);

Console.ReadKey();*/

//tabuada

int num;

Console.WriteLine("Tabuada de ? ");
num = int.Parse(Console.ReadLine());

for(int i = 1; i <= 10; i++)
{ 
    Console.WriteLine("{0} x {1} = {2} ", num, i, num*i);
}

Console.ReadKey();




