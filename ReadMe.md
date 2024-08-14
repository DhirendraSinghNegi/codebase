# Project Codebase

## Overview

Welcome to the Codebase! This repository is a centralized collection of code and resources used across our projects, including Power Apps, SharePoint, Canvas Apps, Power Pages, and more. The goal of this codebase is to promote reusability, consistency, and maintainability throughout our development efforts.

## Folder Structure

This codebase is structured to accommodate various technologies and languages, including:

- **JavaScript/TypeScript**: For custom scripts and web resources.
- **C#**: For plugins, custom workflows, and other server-side logic.
- **Microsoft Power Fx**: For Power Apps expressions and logic.
- **Other**: Additional folders for SharePoint, Canvas Apps, etc., as needed.

Please adhere to the following folder structure when adding new files:

```markdown
|-- OrgReusableCodebase
    |-- PowerApps
        |-- WebResources
            |-- JavaScript
                |-- Common
                    |-- HideShowFields.js
                |-- Specific
                    |-- AccountForm.js
            |-- TypeScript
        |-- Plugins
            |-- CSharp
                |-- Common
                |-- Specific
                    |-- LeadValidation.cs
    |-- SharePoint
        |-- WebParts
            |-- JavaScript
            |-- TypeScript
        |-- Scripts
            |-- JavaScript
    |-- CanvasApps
        |-- Functions
            |-- JavaScript
    |-- PowerPages
        |-- WebResources
            |-- JavaScript
            |-- TypeScript
```


## Coding Conventions

## JavaScript/TypeScript

- **Naming Conventions**:
  - Use camelCase for variables and functions.
  - Use PascalCase for class names.
  - Constants should be in UPPER_SNAKE_CASE.

- **Code Style**:
  - Indentation: 2 spaces.
  - Use `const` or `let` instead of `var`.
  - Always use `===` and `!==` for comparisons.

- **Resources**:
  - [JavaScript Naming Conventions](#)
  - [TypeScript Style Guide](#)

## C#

- **Naming Conventions**:
  - Use PascalCase for class, method, and property names.
  - Use camelCase for local variables and parameters.
  - Prefix interfaces with `I`.

- **Code Style**:
  - Indentation: 4 spaces.
  - Use explicit access modifiers (public, private, etc.).
  - Follow the [Microsoft C# Coding Conventions](#).

- **Resources**:
  - [C# Naming Guidelines](#)
  - [C# Coding Standards](#)

## Microsoft Power Fx

- **Naming Conventions**:
  - Use PascalCase for formulas and variables.
  - Prefix components with their type (txt, lbl, btn, etc.).

- **Code Style**:
  - Keep formulas simple and focused.
  - Break down complex logic into reusable variables.

- **Resources**:
  - [Power Fx Overview](#)
  - [Power Fx Coding Standards](#)

## Comment Conventions

## JavaScript/TypeScript

Use JSDoc for function and method documentation.

Example:

```javascript
/**
 * Calculates the sum of two numbers.
 * @param {number} a - The first number.
 * @param {number} b - The second number.
 * @returns {number} The sum of the two numbers.
 */
function add(a, b) {
    return a + b;
}
```

## C#
Use XML comments for methods, classes, and properties.

Example:

```csharp

/// <summary>
/// Calculates the sum of two numbers.
/// </summary>
/// <param name="a">The first number.</param>
/// <param name="b">The second number.</param>
/// <returns>The sum of the two numbers.</returns>
public int Add(int a, int b)
{
    return a + b;
}
```

## Microsoft Power Fx
Use inline comments to explain complex formulas.

Example:
```plaintext
// Calculate total price including tax
Price * (1 + TaxRate)
```
## Contributing
We welcome contributions to this codebase! Please follow these guidelines:

## How to Contribute
- Fork the repository: Create your own copy of the codebase.
- Create a branch: Make a branch specific to the feature or issue you're working on.
- Make your changes: Ensure your code follows the coding and comment conventions outlined above.
- Commit your changes: Use meaningful commit messages (see below).
- Submit a pull request: Request to merge your branch into the main codebase.
## How to Add Issues and Features
- Create an Issue:
  - Navigate to the "Issues" tab.
  - Click "New Issue".
  - Provide a descriptive title and detailed description.
  - Assign the appropriate labels (e.g., bug, enhancement, question).
  - Create a Feature Request:
# Follow the same steps as creating an issue.
- Use the label "feature request".
- Labeling Issues
  - bug: Report a bug or problem with the code.
  - enhancement: Suggest an improvement or new feature.
  - documentation: Request updates or additions to documentation.
  - question: Ask a question about the codebase.
## Resources

Here are some useful links to learn more about coding conventions:

- **JavaScript**: [Airbnb JavaScript Style Guide](https://github.com/airbnb/javascript)
- **TypeScript**: [TypeScript Best Practices](https://www.typescriptlang.org/docs/handbook/declaration-files/do-s-and-don-ts.html)
- **C#**: [Microsoft C# Coding Conventions](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/coding-conventions)
- **Microsoft Power Fx**: [Power Fx Language Reference](https://docs.microsoft.com/en-us/power-platform/power-fx/overview)

### License
This project is licensed under the free License - see the LICENSE.md file for details.
