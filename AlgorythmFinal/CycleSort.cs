namespace AlgorithmsAnalysis;

class CycleSort : IResercheable
    {
        public static void Swap(ref int leftItem, ref int rightItem)
        {
            int temp = leftItem;

            leftItem = rightItem;

            rightItem = temp;
        }
        public override void Run(int[] array, int value)
        {
            for (int cycleStart = 0; cycleStart < array.Length - 1; cycleStart++)
            {
                int elem = array[cycleStart];
                int pos = cycleStart;

                //Ищем, куда вставить элемент
                for (int i = cycleStart + 1; i < array.Length;i++)
                {
                    if (array[i] < elem)
                    {
                        pos += 1;
                    }
                }
                //Если элемент уже стоит на месте, то сразу
                //переходим к следующей итерации цикла
                if (pos == cycleStart) continue;

                //В противном случае, помещаем элемент на своё
                //место или сразу после всех его дубликатов
                while (elem == array[pos])
                {
                    pos += 1;
                }

                Swap(ref array[pos], ref elem);


                //Циклический круговорот продолжается до тех пор,
                //пока на текущей позиции не окажется её элемент
                while (pos != cycleStart)
                {
                    //Ищем, куда переместить элемент
                    pos = cycleStart;
                    for (int i = cycleStart + 1; i < array.Length; i++)
                    {
                        if (array[i] < elem)
                        {
                            pos += 1;
                        }
                    }
                    //Помещаем элемент на своё место
                    //или сразу после его дубликатов
                    while (elem == array[pos])
                    {
                        pos += 1;
                    }

                    Swap(ref array[pos], ref elem);
                }
            }
            
            
        }
        public CycleSort(int size,string name) : base(size,name)
        {
        }
    }