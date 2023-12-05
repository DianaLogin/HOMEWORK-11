using System;
namespace HOMEWORK_11
{
    internal class Buildingsss
    {
        private int[] builds = new int[10];

        //индексатор
        public int this[int index]
        {
            get
            {
                if (index >= 0 && index < 10)
                {
                    return builds[index];
                }
                else
                {
                    throw new IndexOutOfRangeException("Выберите индекс из предложенных 10 индексов!");
                }
            }
            set
            {
                if (index >= 0 && index < 10)
                {
                    builds[index] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("Выберите индекс из предложенных 10 индексов!");
                }
            }
        }
    }
}
