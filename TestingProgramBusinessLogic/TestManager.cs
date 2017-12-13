using System;
using System.Collections.Generic;

namespace TestingProgramBusinessLogic
{
    public class TestManager
    {
        #region Defenitions

        /// <summary>
        /// Информационный делегат
        /// </summary>
        /// <param name="sendler">Объект инициатор события</param>
        /// <param name="e">Аргументы события</param>
        public delegate void MessagingDelegate(object sendler, TestingEventArgs e);

        /// <summary>
        /// Информационное событие
        /// </summary>
        public event MessagingDelegate Messaging = (obj, e) => { };

        /// <summary>
        /// Количество попыток
        /// </summary>
        public int TryCount { get; private set; }

        /// <summary>
        /// Обратный отсчет
        /// </summary>
        public TimeSpan Countdown { get; private set; }

        /// <summary>
        /// Используется, для получения случайного варианта
        /// </summary>
        private Random rnd = new Random();

        /// <summary>
        /// Список вариантов
        /// </summary>
        private List<Variant> m_variants;

        /// <summary>
        /// Номер текущего варианта
        /// </summary>
        private int m_currentVariant;

        #endregion #region Defenitions

        /// <summary>
        /// Конструктор менеджера тестирования
        /// </summary>
        /// <param name="loader">Коллекция объектов, реализующая интерефейс <see cref="IDataLoader{T}"/></param>
        public TestManager(IDataLoader<Variant> loader)
        {
            m_variants = new List<Variant>();
            m_variants.AddRange(loader.GetCollection());
        }

        /// <summary>
        /// Запуск теста и получение данных варианта
        /// </summary>
        /// <param name="tryCount">Количество попыток</param>
        /// <param name="testingTime">Время на выполнение теста (минут)</param>
        /// <returns>Вариант решения типа <see cref="Variant"/></returns>
        public Variant StartTest(int tryCount, int testingTime)
        {
            TryCount = tryCount > 0 ? tryCount : 1;
            Countdown = new TimeSpan(0, testingTime > 0 ? testingTime : 1, 0);
            m_currentVariant = rnd.Next(m_variants.Count);
            return m_variants[m_currentVariant];
        }

        /// <summary>
        /// Метод отсчета. Должен вызываться каждую секунду.
        /// </summary>
        public void Tick()
        {
            if (Countdown.TotalSeconds > 0)
            {
                Countdown = Countdown.Subtract(new TimeSpan(0, 0, 1));
                if (TryCount == 0)
                {
                    Messaging.Invoke(this, new TestingEventArgs(TestStatus.EndOfTryCount, String.Format("Количество попыток исчерпано!")));
                }
            }
            else
            {
                Messaging.Invoke(this, new TestingEventArgs(TestStatus.EndOfTime, "Время закончилось!"));
            }
        }

        /// <summary>
        /// Метод проверки окончания тестирования
        /// </summary>
        /// <returns>Возвращает true, если тест закончен, в противном случае возвращает false</returns>
        public bool IsTestFinished()
        {
            bool finished = !(TryCount > 0 && Countdown.TotalSeconds > 0);
            return finished;
        }

        /// <summary>
        /// Метод проверки варианта
        /// </summary>
        /// <param name="userAnwser">Ответ пользователя</param>
        /// <returns>В случае правильного отвера возвращает </returns>
        public bool CheckAnwser(double userAnwser)
        {
            double errorValue = 0.05;
            bool result = Math.Abs(m_variants[m_currentVariant].Answer - userAnwser) < errorValue;
            if (!result)
            {
                TryCount--;
                if (TryCount > 0)
                {
                    Messaging.Invoke(this, new TestingEventArgs(TestStatus.WrongAnswer, String.Format("Неправильный ответ!\nОставшееся количество попыток: {0}", TryCount)));
                }
            }
            else
            {
                Messaging.Invoke(this, new TestingEventArgs(TestStatus.Complete, String.Format("Поздравляем!\nВы успешно выполнили тест!")));
            }
            return result;
        }
    }
}
