﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingProgramBusinessLogic
{
    public class TestManager
    {
        public int TryCount { get; private set; }
        public DateTime Countdown { get; private set; }

        private Random rnd = new Random();
        private List<Variant> m_variants;

        /// <summary>
        /// Конструктор менеджера тестирования
        /// </summary>
        public TestManager()
        {
            m_variants = new List<Variant>();
        }

        /// <summary>
        /// Метод загрузки коллекции вариантов
        /// </summary>
        /// <param name="loader">Коллекция объектов, реализующая интерефейс <see cref="IDataLoader{T}"/></param>
        public void Load(IDataLoader<Variant> loader)
        {
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
            TryCount = tryCount;
            Countdown = new DateTime(0, 0, 0, 0, testingTime, 0);
            int rndIndex = rnd.Next(m_variants.Count);
            return m_variants[rndIndex];
        }

        /// <summary>
        /// Метод отсчета. Должен вызываться каждую секунду.
        /// </summary>
        public void Tick()
        {
            if(!IsTestFinished())
            {
                Countdown.Subtract(new DateTime(0, 0, 0, 0, 0, 1));
            }
        }

        // Метод проверки окончания:
        public bool IsTestFinished()
        {
            return currentTime >= m_finishTime ? true : false;
        }

        public bool CheckAnwser(double userAnwser, out int tryCount)
        {
            double errorValue = 0.01;
            // TODO: См. TODO выше xD
            // return (userAnwser > <правильный ответ> + <правильный ответ> * errorValue) && (userAnwser < <правильный ответ> - <правильный ответ> * errorValue) ? true : tryCount--;
        }
        
    }
}
