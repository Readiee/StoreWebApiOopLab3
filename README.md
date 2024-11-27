# ООП - Лабораторная работа №3
## Галсанов Булат M4105

Учебный проект на основе Web API (ASP.NET), созданный с использованием .NET Core 8.0.

--> [Техническое задание](https://docs.google.com/document/d/1Pqu6B-3KE_ydKBFI-2PB5lW3IeLheFn00yZDCoFi3e4/)

## Установка

Клонируйте репозиторий:
```sh
git clone https://github.com/Readiee/StoreWebApiOopLab3.git
```

Установите зависимости:
```sh
dotnet restore
```

Создайте миграцию:
```sh
dotnet ef migrations add InitialCreate --project .\DAL\DAL.csproj
```

Примените миграции к базе данных:
```sh
dotnet ef database update --project .\DAL\DAL.csproj
```

Запустите проект:
```sh
dotnet run --project .\API\API.csproj
```

Адрес Swagger UI:
```sh
/swagger/index.html
```
