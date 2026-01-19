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

The preprocessor utilises Python (3.x) to perform compile evaluation of the code as well as some built in directives which use `#` and terminate with `;`.

### Built-in Directives

- `alias <alias> <substitution>;` - replaces the <alias> with the <substitution> (substitution is defined as anything before the termination`;`)
- `include <relative_path_to_file_POSIX_style>` - Copy-paste file contents into this file at the given line (if the new file contains Java++, it will run the preprocessing stop on that file before insertion)

### Python Runtime Evaluation

You can use `%%` to begin a Python context window, anything in `%%` before the terminating `%%;` will be treated as Python code.

So platform specific code may use:
```java
%%
import platform

if platform.system() == "Linux":
    %%;
        System.out.println("You're using Linux!");
    %%
else:
    %%;
    System.out.println("You're not using Linux!");
    %%
$$;
```

Each block is run one after another and then the output inserted.

## QOL Changes

- alias string to String globally.
