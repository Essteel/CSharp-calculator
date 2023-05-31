while (true) {
    Console.WriteLine("Please provide the first number:");
    var num1 = Console.ReadLine();

    if (num1 == "X") {
        break;
    }

    var firstNumber = int.Parse(num1);

    Console.WriteLine("Please provide the second number:");
    var num2 = Console.ReadLine();

    if (num2 == "X") {
        break;
    }

    var secondNumber = int.Parse(num2);

    Console.WriteLine("Please select an operation to perform:");
    
    Console.WriteLine("+ = addition");
    Console.WriteLine("- = subtraction");
    Console.WriteLine("/ = division");
    Console.WriteLine("* = multiplication");

    Console.WriteLine("X = exit");

    var UserInput = Console.ReadLine();

    if (UserInput == "X") {
        break;
    }

    switch (UserInput) {
        case "+": {
            Console.WriteLine($"= {add(firstNumber, secondNumber)}");
            break;
        }
        case "-": {
            Console.WriteLine($"= {subtract(firstNumber, secondNumber)}");
            break;
        }
        case "/": {
            Console.WriteLine($"= {divide(firstNumber, secondNumber)}");
            break;
        }
        case "*": {
            Console.WriteLine($"= {multiply(firstNumber, secondNumber)}");
            break;
        }
        default: {
            Console.WriteLine("I didn't understand that command, please try again");
            break;
        }
    }
    Console.WriteLine("Press any key to continue");
    Console.ReadKey();
}

static int add(int firstNumber, int secondNumber) {
    return firstNumber + secondNumber;
}

static int subtract(int firstNumber, int secondNumber) {
    return firstNumber - secondNumber;
}

static int divide(int firstNumber, int secondNumber) {
    return firstNumber / secondNumber;
}

static int multiply(int firstNumber, int secondNumber) {
    return firstNumber * secondNumber;
}
