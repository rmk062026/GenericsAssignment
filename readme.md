# Generics Assignment

## Goal

Create a generic class in C# and use an interface to make the code reusable and flexible.

The purpose of this assignment is to practice generics, interfaces and generic collections such as `List<T>`.

## Plan

1. Create a generic interface `IRepository<T>`.
2. Create a generic class `Repository<T>` that implements the interface.
3. Store items in a `List<T>`.
4. Add methods for adding, retrieving and removing items.
5. Test the same repository with more than one data type.
6. Add a generic constraint.
7. Reflect on how generics could be used in a larger application.

## Project Structure

```text
GenericsAssignment
├── Interfaces
│   └── IRepository.cs
├── Repositories
│   └── Repository.cs
├── Models
│   └── Contact.cs
├── Program.cs
├── GenericsAssignment.csproj
└── README.md
```

## Pseudocode

```text
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
    Add strings
    Get all strings
    Display strings

    Create Repository<Contact>
    Add contacts
    Get all contacts
    Display contacts
```

## Generic Interface

The `IRepository<T>` interface defines which methods a repository must implement.

The generic type `T` means that the interface can be used with different data types.

For example:

```csharp
IRepository<string>
IRepository<Contact>
```

The interface acts as a contract for the `Repository<T>` class.

## Generic Repository

The `Repository<T>` class implements `IRepository<T>`.

It uses a generic `List<T>` to store items.

This means that the same repository code can be reused with different data types without creating separate repository classes for every type.

For example:

```csharp
Repository<string>
Repository<Contact>
```

When `Repository<string>` is used, `T` represents `string`.

When `Repository<Contact>` is used, `T` represents `Contact`.

## Methods

The repository contains the following methods:

### Add

Adds an item of type `T` to the repository.

```csharp
void Add(T item)
```

### GetAll

Returns all stored items.

```csharp
List<T> GetAll()
```

### Remove

Removes an item from the repository and returns whether the item was successfully removed.

```csharp
bool Remove(T item)
```

## Generic Constraint

The repository uses the following constraint:

```csharp
where T : class
```

This means that `T` must be a reference type, such as a class or `string`.

For example, these types can be used:

```csharp
Repository<string>
Repository<Contact>
```

A value type such as `int` cannot be used with this constraint.

## Reflection

Generics make it possible to reuse the same code with different data types.

Without generics, separate repository classes could be needed for different types such as contacts, products or users. With `Repository<T>`, the same logic can be reused for all of these types.

The `IRepository<T>` interface defines a contract for the repository. This makes the structure clearer and could make the code easier to replace, test or extend in a larger application.

A similar generic repository could be used in a backend application to work with models such as users, products, orders or contacts.

It could also later be connected to a database or used together with an API.
