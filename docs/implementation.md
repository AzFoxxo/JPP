# Java++ Implementation

Java++ tool is used to take `.jpp` files and convert them to their corresponding Java code.

The tool should be named `jpp` and added to the path.

## Flags

- `jpp --in <file_path>` - will take the JPP file and print the output to the console if not paired with the out flag.
  
- `jpp --out <file_path>` - will take in file and write the Java to the out file (requires input).

- `jpp --project` - will take a given directory and treat that as a project, writing all files in to the out path.

- `jpp --version` - will print the current version of Java++.

- `jpp --help` will print this help info to the console.
