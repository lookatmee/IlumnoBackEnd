![image](https://github.com/user-attachments/assets/da22cf55-d49b-4a37-8159-4533b9a28521)

# Prueba Técnica - Parte BackEnd

Este proyecto BackEnd fue desarrollado utilizando **Visual Studio 2022** y está estructurado de la siguiente manera:

## Tecnologías Utilizadas
- 🔧 **.net 8**
- 🔧 **Sql Server 2022**
- 🔧 **FluentValidation**
- 🔧 **AutoMapper**

## Arquitectura y Principios de Diseño 
- 🧩 **Arquitectura Hexagonal**
- 🧩 **Principios SOLID**
- 🧩 **Arquitectura DDD (Domain-Driven Design)**
- 🧩 **Patrón CQRS (Command Query Responsibility Segregation)**
- 🧩️ **ORM: Entity Framework Core**

## Base de Datos:
La base de datos utilizada es Sql Server 2022. 
El proyecto utiliza Migraciones para poder crear la base de datos y junto con la data semilla puede utilizar en la consola nugget para generar la base de datos:
```bash
update-database
```

## Docker
El proyecto está dockerizado: 
![image](https://github.com/user-attachments/assets/87189e58-42cd-49d8-9fde-25a4774c81d0)
![image](https://github.com/user-attachments/assets/0882c614-57a1-4d0e-8bb3-5cb58e9d2b7c)


## Publicación
A continuación, muestro los EndPoints utilizados

- http://ilumno.somee.com/api/Formulario/
- http://ilumno.somee.com/api/vocabularios/
