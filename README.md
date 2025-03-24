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

## Использование библиотеки
Для использования методов библиотеки, необходимо добавить ссылку на ClassLibrary2. Пример использования:
```
using ClassLibrary2;

public class Program
{
    public static void Main()
    {
        
    }
}
```

## Настройка CI/CD
```
name: .NET Core Desktop
on:
  push:
    branches: [ "master" ]
  pull_request:
    branches: [ "master" ]

jobs:
  build:

    strategy:
      matrix:
        configuration: [Debug]

    runs-on: windows-latest  

    env:
      Solution_Name: ClassLibrary2.sln  
      Test_Project_Path: ClassLibrary2/ClassLibrary2.csproj  

    steps:
    - name: Checkout repository
      uses: actions/checkout@v4
      with:
        fetch-depth: 0

    - name: Install .NET SDK
      uses: actions/setup-dotnet@v4
      with:
        dotnet-version: 8.0.x


    - name: Execute unit tests
      run: dotnet test ${{ env.Solution_Name }} --configuration ${{ matrix.configuration }} --no-build
```

## Для того чтобы запустить юнит-тесты, выполните команду в терминале:

```dotnet test ClassLibrary2.sln --configuration Debug --no-build```


