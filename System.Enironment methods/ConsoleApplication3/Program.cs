using System;



class project
{
    class program
    {

        static void Main(string[] args)
        {

            SystemEnvironmentmethods();

            
        Console.ReadKey();
        }

        private static void SystemEnvironmentmethods()
        {
            Console.WriteLine("There is some information about my PC with System.Environment");
            Console.WriteLine();
            Console.WriteLine();
            //Возвращает командную строку Environment.CommandLine
            Console.WriteLine("CommandLine: {0}", Environment.CommandLine);
            Console.WriteLine();
            // Возвращает полный путь файла Environment.CurrentDirectory
            Console.WriteLine("CurrentDirectory: {0}", Environment.CurrentDirectory);
            Console.WriteLine();
            // Возвращает уникальный идентификатор текущего потока 
            Console.WriteLine("CurrentManagedThreadId: {0}", Environment.CurrentManagedThreadId);
            Console.WriteLine();
            // Возвращает или задает код выхода из проекта
            Console.WriteLine("Код выхода из прог.: {0}", Environment.ExitCode);
            Console.WriteLine();
            // Возвращает логические  диски
            Console.WriteLine("Логические диски: {0}", Environment.GetLogicalDrives());
            Console.WriteLine();
            // Является ли OS 64 битной
            Console.WriteLine("Is 64 bit system: {0}", Environment.Is64BitOperatingSystem);
            Console.WriteLine();
            // Возвращает имя компьютера
            Console.WriteLine("Имя компьютера: {0}", Environment.MachineName);
            Console.WriteLine();
            // Возвращает версию операционной системы
            Console.WriteLine("Операционная система: {0}", Environment.OSVersion);
            Console.WriteLine();
            // Возвращает число процессоров
            Console.WriteLine("Число процессоров: {0}", Environment.ProcessorCount);
            Console.WriteLine();
            // Возвращает путь к системному каталогу
            Console.WriteLine("Путь системного каталога: {0}", Environment.SystemDirectory);
            Console.WriteLine();
            // Возвращает username
            Console.WriteLine("UserNsme {0}", Environment.UserName);
        } 
    }
    
}
