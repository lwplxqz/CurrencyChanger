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
            if (usd < currentValue)
            {
                Console.WriteLine("Недостаточно средств для совершения операции");
            }
            else if (currentValue * usdToRub < 0.1)
            {
                Console.WriteLine("Недопустимая операция. Минимальная сумма конвертации: 10 копеек");
            }
            else
            {
                usd -= currentValue;
                rub += (currentValue * usdToRub);
                Console.WriteLine($"Ваш баланс: {rub} рублей, {usd} долларов, {eur} евро");
            }
            break;
        case "eurToRub":
            Console.WriteLine("Сколько евро желаете перевести в рубли?");
            currentValue = Convert.ToDouble(Console.ReadLine());
            if (eur < currentValue)
            {
                Console.WriteLine("Недостаточно средств для совершения операции");
            }
            else if (currentValue * eurToRub < 0.1)
            {
                Console.WriteLine("Недопустимая операция. Минимальная сумма конвертации: 10 копеек");
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
            if (rub < currentValue)
            {
                Console.WriteLine("Недостаточно средств для совершения операции");
            }
            else if (currentValue * rubToUsd < 0.01)
            {
                Console.WriteLine("Недопустимая операция. Минимальная сумма конвертации: 1 цент");
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
            if (rub < currentValue)
            {
                Console.WriteLine("Недостаточно средств для совершения операции");
            }
            else if (currentValue * rubToEur < 0.01)
            {
                Console.WriteLine("Недопустимая операция. Минимальная сумма конвертации: 1 евроцент");
            }
            else
            {
                rub -= currentValue;
                eur += (currentValue * rubToEur);
                Console.WriteLine($"Ваш баланс: {rub} рублей, {usd} долларов, {eur} евро");
            }
            break;
        case "usdToEur":
            Console.WriteLine("Сколько долларов желаете перевести в евро?");
            currentValue = Convert.ToDouble(Console.ReadLine());
            if (usd < currentValue)
            {
                Console.WriteLine("Недостаточно средств для совершения операции");
            }
            else if (currentValue * usdToEur < 0.01)
            {
                Console.WriteLine("Недопустимая операция. Минимальная сумма конвертации: 1 евроцент");
            }
            else
            {
                usd -= currentValue;
                eur += (currentValue * usdToEur);
                Console.WriteLine($"Ваш баланс: {rub} рублей, {usd} долларов, {eur} евро");
            }
            break;
        case "eurToUsd":
            Console.WriteLine("Сколько евро желаете перевести в доллары?");
            currentValue = Convert.ToDouble(Console.ReadLine());
            if (eur < currentValue)
            {
                Console.WriteLine("Недостаточно средств для совершения операции");
            }
            else if (currentValue * eurToUsd < 0.01)
            {
                Console.WriteLine("Недопустимая операция. Минимальная сумма конвертации: 1 цент");
            }
            else
            {
                eur -= currentValue;
                usd += (currentValue * eurToUsd);
                Console.WriteLine($"Ваш баланс: {rub} рублей, {usd} долларов, {eur} евро");
            }
            break;
        case "exit":

            break;
        default:
            Console.WriteLine("Не знаю такой команды");
            break;
    }
}