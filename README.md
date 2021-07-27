### SDKLibrary
Основная библиотека web интерфейс к которой необходимо сделать.
Библиотека содержит в себе базовый класс MainClass, экземпляр которого должен принимать UI предоставляя графический интерфейс к нему и его элементам. MainClass каждые 100 мс генерирует изображение с текущем временим (OutputData), основываясь на настройках (InputData)

### MainClass
+ Событие EventHandler<OutputData> NewData. Происходит каждые 100мс если SendData==true. UI должен подписаться на него и отобразить OutputData.Image и OutputData.DateTime
+ SendData этим свойство указывает нужно ли генерировать OutputData и вызывать NewData
+ InputData – содержит настройки, которыми должно быть возможно управлять в UI

### InputData

+ Color – Ui должен позволять выбирать либо System.Drawing.Color.Red либо System.Drawing.Color.White
+ Points – каждая точка отображается на OutputData.Image. UI должен давать возможность добавлять эти точки. X- горизонталь, Y- вертикаль. Начало координат верхний левый угол. Диапазон значений [0-1)
 
### MainApp

Приложение, которое создаёт экземпляр MainClass из SDKLibrary и передает его в UI, в данный момент это AvaloniaUI. Ваш UI должен заменить AvaloniaUI.
```C#
SDKLibrary.MainClass mainClass = new SDKLibrary.MainClass();
AvaloniaUI.Program.RunUI(mainClass); //Убираем эту строку и пишем свою инициализацию UI
Console.ReadKey();
```

### AvaloniaUI
AvaloniaUI пример реализации UI
 
### Требования к UI
Функциональные:
1.       Отображать изображение OutputData.Image
2.       Отображать время  OutputData.DateTime
3.       Показывать одно изображение.  Для этого  SendData=true и привой обработке события NewData вернуть SendData=false
4.       Начинать и завершать непрерывный показ изображений  SendData= true/false
5.       Управлять цветом текста на изображении  InputData.Сolor. Цвета только  Red и  White
6.       Позволять ставить метки на изображении InputData.Points
Технические:
1.       Язык C#
2.       dotnetcore
3.       win64 и linux arm
4.       web
5.       Проверку данных, комментарии и прочее делать не нужно
 
Нужно добавить свой проект с UI в решение и модифицировать  MainApp.Program.cs. Должно запускаться по dotnet run в директории MainApp.   
 

