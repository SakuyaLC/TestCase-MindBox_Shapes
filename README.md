## Вопрос №1.
Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам. Дополнительно к работоспособности оценим:
- Юнит-тесты

- Легкость добавления других фигур

- Вычисление площади фигуры без знания типа фигуры

- Проверку на то, является ли треугольник прямоугольным"

Структура проекта легкая и понятная, так что можно обойтись без ссылок на отдельные части кода.

## Вопрос №2.
В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов.
Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.

```
SELECT P.ProductName AS 'Имя продукта', ISNULL(C.CategoryName, 'Без категории') AS 'Имя категории'
FROM Products P
LEFT JOIN ProductCategory PC
	ON P.ProductID = PC.ProductID
LEFT JOIN Categories C
	ON PC.CategoryID = C.CategoryID;
```
**LEFT JOIN для вывода всех товаров. Если у товара нет категории то будет null, который заменится на строку "Без категории" функцией ISNULL**
