# Java++ Specification

List of additions/changes from vanilla Java:

- String interpolation
- Preprocessor support
- QOL changes

## Braking Changes

Java++ will not compile using a standard Java compiler without preprocessing. All `.jpp` files must undergo preprocessing to expand the additions into regular Java code.

Use of string interpolation without preprocessing will not prevent compilation, unlike other changes, but will not work as intended.

## String Interpolation

String interpolation uses the symbol `$` followed by `{}` for the variable or code to insert within the string.

For instance, this Java++ code here implements both variable insertion and expression evaluation insertion:

```java
public class Main {
    public static void main(String[] args) {
        String name = "Az";
        int age = 22;
        System.out.println("${name} is ${age} years old.");
        System.out.println("Next year, ${name} will be ${age + 1}.");
    }
}
```

This is then expanded to the following Java code, replacing `${}` inclusions with `+` in Java:

```java
public class Main {
    public static void main(String[] args) {
        String name = "Az";
        int age = 22;
        System.out.println(name + " is " + age + " years old.");
        System.out.println("Next year, " + name + " will be " + (age + 1) + ".");
    }
}
```

## Preprocessor Support


## QOL Changes
