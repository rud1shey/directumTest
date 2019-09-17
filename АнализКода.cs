//Данный код добавляет в массив новый элемент и сортируем его

static void Func1(ref KeyValuePair<int, string>[] a, int key, string value)
{
    //Увеличиваем количество эллементов массива на 1
    Array.Resize(ref a, a.Length + 1);
    //Создаём новую переменную тип KeyValuePair
    var keyValuePair = new KeyValuePair<int, string>(key, value);
    //Добавляем эллемент в массив
    a[a.Length - 1] = keyValuePair;
    for (int i = 0; i < a.Length; i++)
    {
        for (int j = a.Length - 1; j > 0; j--)
        {
            //Производим сортировку пузырьком
            if (a[j - 1].Key > a[j].Key)
            {
                KeyValuePair<int, string> x;
                x = a[j - 1];
                a[j - 1] = a[j];
                a[j] = x;
            }
        }
    }
}

//Измененный вариант
static void Func1(ref KeyValuePair<int, string>[] A, int key, string value)
{
    //Так же увеличиваем количество значний в массиве
    Array.Resize(ref A, A.Length + 1);
    A[A.Length - 1] = new KeyValuePair<int, string>(key, value);
    KeyValuePair<int, string> t;
    int k, i, t, j;
    //Т.к. сортировка пузырьком не совсем оптимальна, воспользуемся сортировкой Шелла
    for (k = A.Length / 2; k > 0; k = k / 2)
    {
        //Сортировка Шелла
        for (i = k; i < A.Length; i++)
        {
            t = A[i];
            for (j = i; j >= k; j -= k)
            {
                if (t.Key < A[j - k].Key)
                {
                    A[j] = A[j - k];
                }
                else
                    break;
            }
            A[j] = t;
        }
    }
}