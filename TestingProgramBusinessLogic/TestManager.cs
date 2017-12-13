using System;
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

        private TestManager() {  }

        /// <summary>
        /// Запуск тестирования
        /// </summary>
        /// <param name="tryCount">Количество попыток</param>
        /// <param name="testingTime">Время на выполнение теста (минут)</param>
        public TestManager (int tryCount, int testingTime)
	    {
            m_variants = new List<Variant>();
            TryCount = tryCount;
            Countdown = new DateTime(0, 0, 0, 0, testingTime, 0);
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
        /// Запуск тесста и получение данных варианта
        /// </summary>
        /// <returns>Вариант решения типа <see cref="Variant"/></returns>
        public Variant StartTest()
        {
            int rndIndex = rnd.Next(m_variants.Count);
            return m_variants[rndIndex];
        }

        // Метод проверки окончания:
        public bool IsTestFinished(int currentTime)
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
