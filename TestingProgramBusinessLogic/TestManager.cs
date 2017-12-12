using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingProgramBusinessLogic
{
    public class TestManager
    {
        //TODO: Prop:Try count
        //TODO: Prop:Свойство количество тиков

        private int m_tryCount;
        private int m_finishTime;

        private TestManager() {  }
        
        public TestManager (int tryCount, int finishTime)
	    {
            m_tryCount = tryCount;
            m_finishTime = finishTime;
	    }

        //TODO: Старт варианта () -> Time <- CurrentTime + 45 min ==> Variant 
        public void StartTest()
        {

        }

        //TODO: Tick() <- 
        //TODO: Метод проверки окончания () <- Bool 
        public bool IsTestFinished(int currentTime)
        {
            return currentTime >= m_finishTime ? true : false;
        }

        //TODO: Метод ввода ответа
        public double GetAnwser()
        {

        }
        
    }
}
