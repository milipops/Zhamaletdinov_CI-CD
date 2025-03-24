# ClassLibrary2 — это библиотека для работы с массивами. 
Она предоставляет методы для сортировки, фильтрации и поиска элементов в массивах. Библиотека предоставляет следующие функциональности:

Сортировка массивов — сортировка элементов массива.
Фильтрация массивов — возможность фильтровать массивы по заданным критериям.
Поиск элементов — быстрый поиск элементов в массиве.

# SortArray
Описание: Метод сортировки массива по возрастанию или убыванию. Параметры: array: массив целых чисел, который нужно отсортировать. Возвращаемое значение: Отсортированный массив

# FilterArr
Описание: Метод для фильтрации элементов массива на основе заданного условия. Параметры: array: массив целых чисел для фильтрации. filter: условие для фильтрации. Возвращаемое значение: Отфильтрованный массив.

# FindElem
Описание: Метод для поиска элемента в массиве. Параметры: array: массив, в котором необходимо выполнить поиск. element: элемент для поиска. Возвращаемое значение: Индекс элемента в массиве, если он найден, или -1, если элемент не найден.

## Установка через NuGet 
Вы можете установить библиотеку через NuGet, используя команду:

```dotnet add package ClassLibrary2```

## Для того чтобы запустить юнит-тесты, выполните команду в терминале:

```dotnet test ClassLibrary2.sln --configuration Debug --no-build```


