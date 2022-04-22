string userInput = "";
double usd;
double eur;
double rub;
double usdToRub = 80;
double eurToRub = 87;
double rubToUsd = 0.013;
double rubToEur = 0.012;
double usdToEur = 0.92;
double eurToUsd = 1.09;
double currentValue;

Console.WriteLine("Саламалейком, укажите ваш баланс в рублях: ");
rub = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Yкажите ваш баланс в долларах: ");
usd = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Yкажите ваш баланс в евриках: ");
eur = Convert.ToDouble(Console.ReadLine());

while (userInput != "exit")
{
    Console.WriteLine("Что будем конвертировать?");
    Console.WriteLine("usdToRub - Конвертация долларов в рубли;");
    Console.WriteLine("eurToRub - Евро в рубли;");
    Console.WriteLine("rubToUsd - Рубли в доллары;");
    Console.WriteLine("rubToEur - Рубли в евро;");
    Console.WriteLine("usdToEur - Доллары в евро;");
    Console.WriteLine("eurToUsd - Евро в доллары;");
    Console.WriteLine("exit - Выход.");
    userInput = Console.ReadLine();
    switch (userInput)
    {
        case "usdToRub":
            Console.WriteLine("Сколько долларов желаете перевести в рубли?");
            currentValue = Convert.ToDouble(Console.ReadLine());
            if((currentValue*usdToRub)<1)
            {
                Console.WriteLine("Недостаточно средств для совершения операции");
            }
            else
            {
                usd -= currentValue;
                rub += (currentValue*usdToRub);
                Console.WriteLine($"Ваш баланс: {rub} рублей, {usd} долларов, {eur} евро");
            }
            break;
        case "eurToRub":
            Console.WriteLine("Сколько евро желаете перевести в рубли?");
            currentValue = Convert.ToDouble(Console.ReadLine());
            if ((currentValue * eurToRub) < 1)
            {
                Console.WriteLine("Недостаточно средств для совершения операции");
            }
            else
            {
                eur -= currentValue;
                rub += (currentValue * eurToRub);
                Console.WriteLine($"Ваш баланс: {rub} рублей, {usd} долларов, {eur} евро");
            }
            break;
        case "rubToUsd":
            Console.WriteLine("Сколько рублей желаете перевести в доллары?");
            currentValue = Convert.ToDouble(Console.ReadLine());
            if ((currentValue * rubToUsd) <= 0.01)
            {
                Console.WriteLine("Недостаточно средств для совершения операции");
            }
            else
            {
                rub -= currentValue;
                usd += (currentValue * rubToUsd);
                Console.WriteLine($"Ваш баланс: {rub} рублей, {usd} долларов, {eur} евро");
            }
            break;
        case "rubToEur":
            Console.WriteLine("Сколько рублей желаете перевести в евро?");
            currentValue = Convert.ToDouble(Console.ReadLine());
            if ((currentValue * rubToEur) <= 0.01)
            {
                Console.WriteLine("Недостаточно средств для совершения операции");
            }
            else
            {
                rub -= currentValue;
                eur += (currentValue * rubToEur);
                Console.WriteLine($"Ваш баланс: {rub} рублей, {usd} долларов, {eur} евро");
            }
            break;
        default:
            Console.WriteLine("Не понимаю тебя баран е6аный");
            break;
    }
}