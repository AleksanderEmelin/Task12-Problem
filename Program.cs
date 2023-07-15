            int Input(string text)
        {
            Console.Write(text);
            return Convert.ToInt32(Console.Readline());
        }

       
        void Task12()
        {
            // напишите программу, которая будет принимать на вход 2 числа и 
            //вывадить, является ли второе число кратным первому

            
            int number_f = Input("Введите первое число:  ");

            int number_s = Input("Введите второе число:  ");

            if (number_s % number_f == 0)
            {
                Console.WriteLine($"Число {number_s}  кратно числу {number_f}");
            }
            else
            {
                Console.WriteLine($"Число {number_s} Не кратно числу {number_f}."
                   + $"Остаток от деления равен {number_s % number_f}");
            }
        }
        Console.Clear();
    
        Task12();
