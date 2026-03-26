namespace lucy
{
    class ServerEventArgs: EventArgs{
        public int Value { get; set; }
        public string Message { get; set; }
    }
    class ServerMonitor
    {
       public  event EventHandler<ServerEventArgs>? ThresholdReached;
        protected virtual void OnChanged(int value)
        {
            ThresholdReached?.Invoke(this, new ServerEventArgs {Value = value,Message = "Alert"});
        }
        public void Start()
        {
            int value = 0;
            for (int i = 0; i < 10; i++)
            {
                Random rnd = new Random();
                 value = rnd.Next(0, 101);

            }
            if (value > 80)
            {
                OnChanged(value);
            }
        }
       
    }
    static class Logger
    {
        public static void LogThreshold(object? sender, ServerEventArgs e)
        {
            Console.WriteLine(e.Message, e.Value);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
           ServerMonitor monitor = new ServerMonitor();

            monitor.ThresholdReached += Logger.LogThreshold;


        }
    }
}
Система умных уведомлений
Создать консольное приложение, которое имитирует работу датчика (температуры или нагрузки CPU) и оповещает разные службы о критических изменениях.
1. Модель данных
Создайте класс ServerEventArgs (наследник EventArgs), который содержит:
int Value (текущее значение).
string Message (сообщение).
2. Источник событий
Создайте класс ServerMonitor:
Событие: event EventHandler<ServerEventArgs> ThresholdReached.
Метод (виртуальный и доступен в самом классе и в производных): OnChanged для вызова события
Метод: Start(), который в цикле (на 5–10 итераций) генерирует случайное число (0–100).
Логика: Если число > 80, вызывается событие.
3. Подписки и Лямбды
В методе Main реализуйте три типа подписчиков, используя разные подходы:
Классический метод: Создайте отдельный класс Logger, который записывает данные в консоль при срабатывании.
Лямбда-выражение: Подпишитесь на событие и просто выводите текст: "Срочно! Значение превысило норму!".
Замыкание: Объявите локальную переменную int alertCount = 0. В подписке (через лямбду) инкрементируйте этот счетчик при каждом вызове и выводите: "Это уже {alertCount} предупреждение за сессию".
4. Доп. задание на делегаты
Добавьте в ServerMonitor свойство Predicate<int> Filter.
Пусть событие срабатывает только если Filter(value) возвращает true.
