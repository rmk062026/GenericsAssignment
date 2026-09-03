# Generics Assignment

## Goal
Create a generic class in C# and use an interface to make the code reusable and flexible.

## Plan
1. Create a generic interface `IRepository<T>`.
2. Create a generic class `Repository<T>` that implements the interface.
3. Store items in a `List<T>`.
4. Add methods for adding, retrieving and removing items.
5. Test the same repository with more than one data type.
6. Reflect on how generics could be used in a larger backend application.

## Planned structure

GenericsAssignment
├── Interfaces
│   └── IRepository.cs
├── Repositories
│   └── Repository.cs
├── Models
│   ├── Contact.cs
│   └── Product.cs
├── Program.cs
└── README.md

## Pseudocode

Create generic interface IRepository<T>
    Define Add method
    Define GetAll method
    Define Remove method

Create generic class Repository<T>
    Implement IRepository<T>
    Create List<T> to store items

    Add(item)
        Add item to list

    GetAll()
        Return all items

    Remove(item)
        Remove item from list
        Return whether removal succeeded

In Program
    Create Repository<string>
    Add some strings
    Display stored strings

    Create Repository<Contact>
    Add contacts
    Display contacts