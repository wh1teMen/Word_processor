# Текстовый процессор :page_with_curl:
*(Реализующий автодополнение слов по требованию пользователя)*
____
### Функции процессора:
+ Загрузка и анализ (входящего) текстового файла для формирования словаря «часто встречающихся слов».
+ Сопровождение словаря с помощью кнопок в верхнем меню программы.
+ Вывод подсказок (автодополнений) к словам в соответствии со сформированным словарём.
___
#### Используемые технологии:
:white_check_mark: ***Visual Studio 2022*** </br>
:white_check_mark:   ***Windows Forms***</br>
:white_check_mark:   ***ООП***</br>
:white_check_mark:  ***ADO.net***</br>
:white_check_mark:   ***SQLite***</br>
:white_check_mark:   ***LINQ***

___
 ## <span style="font-size:22px;font-weight:bold;"> 1. Создание словаря</span>

  #### Условия создания словаря:
   * Поле ввода не должно быть пустым
 #### Результат:
  * Формирование нового словаря по входящему файлу  

<img src="ReadmeContent/Create.gif" Alt="Create">

____

## <span style="font-size:22px;font-weight:bold;">2. Обновление словаря</span>

#### Условия добавления в словарь:
  * Минимальное число символов, воспринимаемых приложением как слово – 3.
  * Минимальное число повторений слова в тексте для включения этого слова - 3. 
#### Результат:
   * Дополнение существующего словаря по входящему файлу.
 

<img src="ReadmeContent/Refresh.gif" Alt="Refresh">

____
## <span style="font-size:22px;font-weight:bold;">3. Очистка  словаря</span>
 
 #### Результат:
   * Удаление всех данных словаря.
<img src="ReadmeContent/Delete.gif" Alt="Delete">


-----
<span style="color: #545463; height:30px; font-size:25px; font-family:COMIC SANS MS,Arial;font-weight:bold;">Выполнил: Белов Александр Сергеевич</span>

----

