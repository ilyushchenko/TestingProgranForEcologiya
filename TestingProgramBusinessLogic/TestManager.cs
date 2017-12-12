using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingProgramBusinessLogic
{
    public class TestManager
    {
        private int m_tryCount;
        private int m_finishTime;

        private Variants m_variants;

        private TestManager() {  }
        
        public TestManager (int tryCount, int finishTime)
	    {
            m_tryCount = tryCount;
            m_finishTime = finishTime;
	    }

        // Получение пользователем данных теста:
        // TODO: На view-часть не должен передаваться ответ! Мб разделить:      данные -> view-часть;      anwser -> prop
        public Variant StartTest()
        {
            // return m_variants.< Функция получения данных случайного варианта >;
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
