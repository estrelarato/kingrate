void Somar(float a, float b){
    float resultado = a + b;
    Console.WriteLine($"{a} + {b} = {resultado}");
}

void Subtrair(float a, float b){
    float resultado = a - b;
    Console.WriteLine($"{a} - {b} = {resultado}");
}

void Multipli(float a, float b){
    float resultado = a * b;
    Console.WriteLine($"{a} * {b} = {resultado}");
}

 void Dividir(float a , float b){
    if(b == 0){
        Console.WriteLine("erro na divisao por zero");
        return;
}
    float resultado = a / b;
     Console.WriteLine($"{a} / {b} = {resultado}");
 }

//variaveis globais
float a;
float b;

void DigitAeB(string operacao){

    Console.WriteLine(operacao);

    Console.WriteLine($"Digite o valor de a") ;
    a = float.Parse(Console.ReadLine());
    Console.WriteLine($"Digite o valor de b");
    b = float.Parse(Console.ReadLine());
}
//MENU
Console.WriteLine("--- CALCULADORA ---");
Console.WriteLine("1 - Somar");
Console.WriteLine("2 - Subtrair");
Console.WriteLine("3 - Multipli");
Console.WriteLine("4 - Dividir");
Console.WriteLine("5 - SAIR");
Console.WriteLine("--------------------");

int opcao = int.Parse(Console.ReadLine());

if(opcao == 1){
    DigitAeB("Somar");
    Somar(a,b);
}
else if(opcao == 2){
    DigitAeB("Subtrair");
    Subtrair(a,b);
}
else if(opcao == 3){
    DigitAeB("Multipli");
    Multipli(a,b);
}
else if(opcao == 4){
    DigitAeB("Dividir");
    Dividir(a,b);
}
else if(opcao == 5){
    Console.WriteLine("Saindo...");
}
else{
    Console.WriteLine("Opção inválida");
} 