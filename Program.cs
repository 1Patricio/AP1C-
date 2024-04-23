bool executador = true; 

while (executador == true)
{
    // Entrada de dados do usuário
    Console.WriteLine("Digite seu nome: ");
    var nome = Console.ReadLine();

    Console.WriteLine("Digite sua idade: ");
    int idade = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Digite sua Altura em metros separador por ,");
    double altura = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Digite seu peso em KG separador por ,");
    double peso = Convert.ToDouble(Console.ReadLine());

    double IMC = Math.Round(peso / (altura * altura), 2); //math round arredonda em duas casa decimais


    //Verificando IMC
    string resultado = ""; //declarando variável fora do if para que se torne global
    if (IMC <= 18.5)
    {
        resultado = "Abaixo do Peso"; //Armazena na variável etaria para depois chamar
    } else if (IMC > 18.6 && IMC <= 24.9){
        resultado = "Peso Normal";
    }else if (IMC >25 && IMC <= 29.9)
    {
        resultado = "Sobrepeso";
    }else if (IMC > 30)
    {
        resultado = "Obesidade";
    }

    // Verificar Faixa Etária
    string etaria = ""; //declarando variável fora do if para que se torne global
    if (idade < 10)
    {
        etaria = "Criança"; //Armazena na variável etaria para depois chamar
    }else if (idade >= 10 && idade < 20)
    {
        etaria = "Adolescente";
    }else if (idade >= 20 && idade <60)
    {
        etaria = "Adulto";
    }else if (idade >= 60)
    {
        etaria = "Idoso";
    }

    //Mostrando Relatório
    Console.WriteLine($"Relatório: {nome} de {idade} anos com indice de IMC {IMC} se classificando como {resultado} e faixa etária {etaria}");

    //Perguntando ao usuário se deseja continuar 
    Console.WriteLine("Você deseja continuar?");
    string resposta = Console.ReadLine().ToLower(); //To Lower vai garantir que as respostas retornem apenas caracteres minúsculos

    if (resposta == "sim" || resposta == "s") //permitindo diferentes tipos de respostas
    {
        executador = true;
    }else{
        executador = false;
    }
}